namespace AwesomeNetdaemon.Features.Builders.SensorObservable.Conditions;

public interface ISensorCondition
{
    public string EntityId { get; }
    int OnPriority { get; set; }
    int OffPriority { get; set; }
    public IObservable<StateWithCondition>? OnObservable();
    public IObservable<StateWithCondition>? OffObservable();
}
