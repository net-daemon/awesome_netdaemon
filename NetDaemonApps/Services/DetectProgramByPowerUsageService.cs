using System.Reactive.Concurrency;
using Microsoft.Extensions.DependencyInjection;

namespace AwesomeNetdaemon.Services;

public class DetectProgramByPowerUsageBuilderFactory(IServiceProvider serviceProvider)
{
    public DetectProgramByPowerUsageBuilder Create() => serviceProvider.GetRequiredService<DetectProgramByPowerUsageBuilder>();
}

public class DetectProgramByPowerUsageBuilder(IScheduler scheduler, ILogger<DetectProgramByPowerUsageBuilder> logger)
{
    private Func<double, bool>? _startFilter;
    private Func<DetectedProgram, bool> _endFilter = _ => true;
    private NumericSensorEntity? _currentPowerSensor;
    private NumericSensorEntity? _totalPowerSensor;

    public DetectProgramByPowerUsageBuilder WithPowerSensor(NumericSensorEntity currentPowerSensor)
    {
        ValidateStateClass(currentPowerSensor, "measurement");
        _currentPowerSensor = currentPowerSensor;
        return this;
    }

    public DetectProgramByPowerUsageBuilder WithTotalPowerSensor(NumericSensorEntity totalPowerSensor)
    {
        ValidateStateClass(totalPowerSensor, "total_increasing");
        _totalPowerSensor = totalPowerSensor;
        return this;
    }

    public DetectProgramByPowerUsageBuilder WithStartFilter(Func<double, bool> filter)
    {
        _startFilter = filter;
        return this;
    }

    public DetectProgramByPowerUsageBuilder WithEndFilter(Func<DetectedProgram, bool> filter)
    {
        _endFilter = filter;
        return this;
    }

    public IObservable<DetectedProgram> Build()
    {
        ArgumentNullException.ThrowIfNull(_startFilter);
        ArgumentNullException.ThrowIfNull(_totalPowerSensor);
        ArgumentNullException.ThrowIfNull(_currentPowerSensor);

        return _currentPowerSensor
            .StateChanges()
            .NotNull()
            .CombineLatest(_totalPowerSensor
                .StateChanges()
                .NotNull()
                .Select(x => x.New?.State ?? 0)
                .Prepend(_totalPowerSensor.State ?? 0))
            .Select(x => (ProgramActive: _startFilter(x.First.New!.State!.Value), TotalPower: x.Second))
            .Timestamp(scheduler)
            .DistinctUntilChanged(x => x.Value.ProgramActive)
            .PairWithPrevious()
            .Do(x =>
            {
                if (x.Current.Value.ProgramActive)
                {
                    logger.LogInformation("Detected start of program for {EntityId}, current total energy: {TotalEnergy}", _currentPowerSensor.EntityId, x.Current.Value.TotalPower);
                }
            })
            .Where(x => x.Current.Value.ProgramActive == false && x.Previous.Value.ProgramActive)
            .Do(x => logger.LogInformation("Detected end of program for {EntityId}, current total energy: {TotalEnergy}", _currentPowerSensor.EntityId, x.Current.Value.TotalPower))
            .Select(x => new DetectedProgram(x.Current.Timestamp - x.Previous.Timestamp, x.Current.Value.TotalPower - x.Previous.Value.TotalPower))
            .Where(x => _endFilter(x));
    }

    private static void ValidateStateClass(NumericSensorEntity entity, string expectedClass)
    {
        if (entity.Attributes == null)
        {
            return;
        }

        if (entity.Attributes.StateClass != expectedClass)
        {
            throw new ArgumentException($"Sensor must be {expectedClass} but was {entity.Attributes.StateClass}");
        }
    }
}

