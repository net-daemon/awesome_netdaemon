using NetDaemon.HassModel.Entities;

namespace AwesomeNetdaemon.Features.Builders.SensorObservable.Conditions;

public record NumericSensorCondition(NumericSensorEntity Sensor) : SensorConditionBase(Sensor.EntityId)
{
    private Func<double, bool>? _offPredicate;
    private Func<double, bool>? _onPredicate;

    public override IObservable<StateWithCondition>? OnObservable() => _onPredicate != null
        ? EntityExtensions.StateChangesWithCurrent(Sensor)
            .Select(x => new StateWithCondition(_onPredicate((double)x.New.DefaultIfNull(0).State!), this))
        : null;

    public override IObservable<StateWithCondition>? OffObservable() => _offPredicate != null
        ? EntityExtensions.StateChangesWithCurrent(Sensor)
            .Select(x => new StateWithCondition(_offPredicate.Invoke((double)x.New.DefaultIfNull(0).State!), this))
        : null;

    public NumericSensorCondition WithHysteresis(double onBelow, double offAbove) => TurnOnOn(y => y < onBelow).TurnOffOn(y => y > offAbove);

    public NumericSensorCondition TurnOnOn(Func<double, bool>? predicate)
    {
        _onPredicate = predicate;
        return this;
    }

    public NumericSensorCondition TurnOffOn(Func<double, bool>? predicate)
    {
        _offPredicate = predicate;
        return this;
    }
}
