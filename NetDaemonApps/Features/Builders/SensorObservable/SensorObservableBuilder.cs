using System.Runtime.CompilerServices;
using AwesomeNetdaemon.Features.Builders.SensorObservable.Conditions;
using Microsoft.Extensions.Logging.Abstractions;

namespace AwesomeNetdaemon.Features.Builders.SensorObservable;

public class SensorObservableBuilder
{
    private readonly List<ISensorCondition> _sensorConditions = [];
    private ILogger? _logger;

    public SensorObservableBuilder WithSensor(BinarySensorEntity? sensor, Action<BinarySensorCondition>? configure = null)
    {
        if (sensor == null) return this;
        var condition = new BinarySensorCondition(sensor, true, false);
        configure?.Invoke(condition);
        _sensorConditions.Add(condition);
        return this;
    }

    public SensorObservableBuilder WithSensor(NumericSensorEntity? sensor, Action<NumericSensorCondition>? configure = null)
    {
        if (sensor == null) return this;
        var condition = new NumericSensorCondition(sensor);
        configure?.Invoke(condition);
        _sensorConditions.Add(condition);
        return this;
    }

    public SensorObservableBuilder WithVerboseLogging(ILogger logger)
    {
        _logger = logger;
        return this;
    }

    public IObservable<bool> ToObservable()
    {
        _logger ??= NullLogger.Instance;

        return _sensorConditions
            .Select(s => s.OnObservable())
            .Where(x => x != null)!
            .CombineLatest()
            .Select(EvaluateOn)
            .Where(x => x)
            .Select(_ => true)
            .Merge(_sensorConditions
                .Select(s => s.OffObservable())
                .Where(x => x != null)!
                .CombineLatest()
                .Select(EvaluateOff)
                .Where(x => x)
                .Select(_ => false))
            .DistinctUntilChanged();
    }

    private bool EvaluateOff(IList<StateWithCondition> conditions) =>
        Evaluate(conditions.GroupBy(x => x.Condition.OffPriority));

    private bool EvaluateOn(IList<StateWithCondition> conditions) =>
        Evaluate(conditions.GroupBy(x => x.Condition.OnPriority));

    private bool Evaluate(IEnumerable<IGrouping<int, StateWithCondition>> conditions, [CallerMemberName] string caller = null!)
    {
        var priorityGroups = conditions.OrderByDescending(x => x.Key);

        foreach (var priorityGroup in priorityGroups)
            if (priorityGroup.All(x => x.State))
            {
                var evaluationState = priorityGroup.Select(x => new
                {
                    x.Condition.EntityId, x.State
                });

                _logger?.LogInformation("Evaluation {Caller} with state {State}", caller, evaluationState);

                return true;
            }

        return false;
    }
}
