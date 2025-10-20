using AwesomeNetdaemon.Features.Builders.SensorObservable;
using AwesomeNetdaemon.Features.Builders.SensorObservable.Conditions;

namespace AwesomeNetdaemon.Features.Builders;

public static class Builders
{
    public static SensorObservableBuilder SensorObservableBuilder() => new();

    public static T WithOffPriority<T>(this T condition, int priority) where T : ISensorCondition
    {
        condition.OffPriority = priority;
        return condition;
    }
}
