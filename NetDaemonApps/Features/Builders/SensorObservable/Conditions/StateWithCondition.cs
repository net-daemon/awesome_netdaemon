namespace AwesomeNetdaemon.Features.Builders.SensorObservable.Conditions;

public record struct StateWithCondition(bool State, ISensorCondition Condition);
