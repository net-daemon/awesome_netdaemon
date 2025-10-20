using NetDaemon.HassModel.Entities;

namespace AwesomeNetdaemon.Features.Builders.SensorObservable.Conditions;

public record BinarySensorCondition(BinarySensorEntity Sensor, bool? OnPoint, bool? OffPoint) : SensorConditionBase(Sensor.EntityId)
{
    public override IObservable<StateWithCondition>? OnObservable() => OnPoint != null
        ? Sensor
            .StateChangesWithCurrent()
            .Select(x => new StateWithCondition(x.New.IsOn() == OnPoint, this))
        : null;

    public override IObservable<StateWithCondition>? OffObservable() => OffPoint != null
        ? Sensor
            .StateChangesWithCurrent()
            .Select(x => new StateWithCondition(x.New.IsOn() == OffPoint, this))
        : null;
}
