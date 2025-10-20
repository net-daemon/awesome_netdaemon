using System.Reactive.Concurrency;
using NetDaemon.HassModel.Entities;

namespace AwesomeNetdaemon.Features.Builders;

public class DetectProgramByPowerUsageBuilderFactory(IServiceProvider serviceProvider)
{
    public DetectProgramByPowerUsageBuilder Create() => serviceProvider.GetRequiredService<DetectProgramByPowerUsageBuilder>();
}

public partial class DetectProgramByPowerUsageBuilder(IScheduler scheduler, ILogger<DetectProgramByPowerUsageBuilder> logger)
{
    private NumericSensorEntity? _currentPowerSensor;
    private Func<DetectedProgram, bool> _endFilter = _ => true;
    private Func<double, bool>? _startFilter;
    private NumericSensorEntity? _totalPowerSensor;

    public DetectProgramByPowerUsageBuilder WithPowerSensor(ISensorEntityCore currentPowerSensor)
    {
        _currentPowerSensor = new NumericSensorEntity(currentPowerSensor);
        ValidateStateClass(_currentPowerSensor, "measurement");
        return this;
    }

    public DetectProgramByPowerUsageBuilder WithTotalPowerSensor(ISensorEntityCore totalPowerSensor)
    {
        _totalPowerSensor = new NumericSensorEntity(totalPowerSensor);
        ValidateStateClass(_totalPowerSensor, "total_increasing");
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
                    Log.LogProgramStart(logger, _currentPowerSensor.EntityId, x.Current.Value.TotalPower);
            })
            .Where(x => !x.Current.Value.ProgramActive && x.Previous.Value.ProgramActive)
            .Do(x => Log.LogProgramEnd(logger, _currentPowerSensor.EntityId, x.Current.Value.TotalPower))
            .Select(x => new DetectedProgram(x.Current.Timestamp - x.Previous.Timestamp, x.Current.Value.TotalPower - x.Previous.Value.TotalPower))
            .Where(x => _endFilter(x));
    }

    private static void ValidateStateClass(NumericSensorEntity entity, string expectedClass)
    {
        if (entity.Attributes == null) return;

        if (entity.Attributes.StateClass != expectedClass) throw new ArgumentException($"Sensor must be {expectedClass} but was {entity.Attributes.StateClass}");
    }

    private static partial class Log
    {
        [LoggerMessage(
            EventId = 2,
            Level = LogLevel.Information,
            Message = "Detected start of program for {EntityId}, current total energy: {TotalEnergy}")]
        public static partial void LogProgramStart(ILogger logger, string entityId, double totalEnergy);

        [LoggerMessage(
            EventId = 3,
            Level = LogLevel.Information,
            Message = "Detected end of program for {EntityId}, current total energy: {TotalEnergy}")]
        public static partial void LogProgramEnd(ILogger logger, string entityId, double totalEnergy);
    }
}
