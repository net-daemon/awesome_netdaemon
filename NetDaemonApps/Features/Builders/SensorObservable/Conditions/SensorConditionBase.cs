namespace AwesomeNetdaemon.Features.Builders.SensorObservable.Conditions;

public abstract record SensorConditionBase(string EntityId) : ISensorCondition
{
    public int OnPriority { get; set; }
    public int OffPriority { get; set; }
    public abstract IObservable<StateWithCondition>? OnObservable();

    public abstract IObservable<StateWithCondition>? OffObservable();
}
