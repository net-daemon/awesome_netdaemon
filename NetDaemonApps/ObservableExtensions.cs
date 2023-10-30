using System.Globalization;
using MathNet.Numerics.Statistics;
using NetDaemon.HassModel.Entities;

namespace MyNetdaemonSmarthome;

public static class ObservableExtensions
{
    public static IObservable<NumericStateChange<TEntity, TEntityState>> NotNull<TEntity, TEntityState>(this IObservable<NumericStateChange<TEntity, TEntityState>> source)
        where TEntityState : NumericEntityState<NumericSensorAttributes>
        where TEntity : Entity
    {
        return source.Where(x => x.New?.State != null);
    }

    public static IObservable<(TSource? Previous, TSource? Current)> PairWithPrevious<TSource>(this IObservable<TSource> source)
    {
        return source.Scan((default(TSource), default(TSource)), (acc, current) => (acc.Item2, current));
    }

    public static NumericEntityState<NumericSensorAttributes> DefaultIfNull(this NumericEntityState<NumericSensorAttributes>? state, double defaultValue)
    {
        return state ?? new NumericEntityState<NumericSensorAttributes>(new EntityState { State = defaultValue.ToString(CultureInfo.InvariantCulture) });
    }

    public static IObservable<StateChange<TEntity, TState>> StateChangesWithCurrent<TEntity, TState, TAttributes>(this TEntity entity)
        where TEntity : Entity<TEntity, TState, TAttributes>
        where TState : EntityState<TAttributes>
        where TAttributes : class
    {
        return entity.StateAllChanges().Prepend(new StateChange<TEntity, TState>(entity, null, entity.EntityState));
    }

    public static IObservable<StateChange<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>>> StateChangesWithCurrent(this NumericSensorEntity entity)
    {
        return StateChangesWithCurrent<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>, NumericSensorAttributes>(entity);
    }

    public static IObservable<double> MovingAverage(this IObservable<double> source, int windowSize)
    {
        return source.MovingAverage(x => x, windowSize);
    }

    public static IObservable<double> MovingAverage(this IObservable<NumericStateChange<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>>> source, int windowSize)
    {
        return source.Where(x => x.New?.State != null).MovingAverage(x => x.New!.State.GetValueOrDefault(), windowSize);
    }

    public static IObservable<double> MovingAverage<TSource>(this IObservable<TSource> source, Func<TSource, double> selector, int windowSize)
    {
        var statistics = new MovingStatistics(windowSize);
        return source.Select(x =>
        {
            var value = selector(x);
            statistics.Push(value);
            return statistics.Mean;
        });
    }

    public static IObservable<TSource> TriggerAndWait<TSource>(this IObservable<TSource> source, Func<TSource, bool> trigger, Func<TSource, bool> reset)
    {
        ArgumentNullException.ThrowIfNull(source);

        bool triggered = false;

        return source.Where(x =>
        {
            if (trigger(x))
            {
                if (!triggered)
                {
                    triggered = true;
                    return true;
                }
            }
            else if (reset(x))
            {
                triggered = false;
            }

            return false;
        });
    }
}
