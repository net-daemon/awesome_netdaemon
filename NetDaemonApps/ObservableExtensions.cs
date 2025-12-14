using System.Globalization;
using System.Reactive.Concurrency;
using AwesomeNetdaemon.Features.Common;
using MathNet.Numerics.Statistics;
using NetDaemon.HassModel.Entities;

namespace AwesomeNetdaemon;

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

    /// <summary>
    /// Calculates a running moving average of a sequence of values.
    /// </summary>
    /// <param name="source"></param>
    /// <param name="selector"></param>
    /// <param name="windowSize"></param>
    /// <typeparam name="TSource"></typeparam>
    /// <returns></returns>
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

    /// <summary>
    /// Will let a value through if <paramref name="trigger"/> returns true and will then block values until <paramref name="reset"/> returns true.
    /// </summary>
    /// <param name="source"></param>
    /// <param name="trigger"></param>
    /// <param name="reset"></param>
    /// <typeparam name="TSource"></typeparam>
    /// <returns></returns>
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

    public static IObservable<double> ToValueObservable(this ScheduleEntity schedule) =>
        schedule.StateAllChangesWithCurrent()
            .Select(x => x.New?.Attributes?.Value ?? 15);

    public static IObservable<double> OverrideValueIfAllNotPresent(this IObservable<double> observable, double value, params PersonEntity[] persons) =>
        observable.CombineLatest(persons.Select(x => x
                    .StateChangesWithCurrent()
                    .Select(y => y.New.IsHome()))
                .CombineLatest()
                .Select(x => x.Contains(true)))
            .Select(x => x.Second ? x.First : value);

    public static void BindToClimate(this IObservable<double> observable, ClimateEntity climate) =>
        observable.Subscribe(x => { climate.SetTemperature(x); });

    public static void BindToClimate(this IObservable<double> observable, params ClimateEntity[] climates) =>
        observable.Subscribe(x =>
        {
            foreach (var climate in climates) climate.SetTemperature(x);
        });

    public static void BindTo(this INumberEntityCore numberEntity, NumericSensorEntity sensor, IScheduler scheduler) =>
        sensor.StateChangesWithCurrent()
            .Where(x => x.New?.State != null)
            .CombineLatest(Observable.Interval(TimeSpan.FromMinutes(50), scheduler)) // Prevent trv from thinking connection was lost.
            .Select(x => x.First.New!.State!.Value)
            .Subscribe(x => { numberEntity.SetValue(x.ToString(CultureInfo.InvariantCulture)); });

    public static IObservable<double> Clamp(this IObservable<double> observable, double min, double max) =>
        observable.Select(x => Math.Clamp(x, min, max));

    public static IObservable<T> EmitLatestPeriodically<T>(this IObservable<T> observable, TimeSpan timeSpan, IScheduler scheduler) =>
        observable.CombineLatest(Observable.Interval(timeSpan, scheduler).Prepend(0))
            .Select(x => x.First);

    public static void BindTo(this IObservable<bool> observable, ISwitchEntityCore switchEntity, ILogger? logger = null) =>
        observable.Subscribe(x =>
        {
            logger?.LogInformation("Setting {EntityId} to {Target}", switchEntity.EntityId, x);
            if (x)
                switchEntity.TurnOn();
            else
                switchEntity.TurnOff();
        });

    public static void BindTo(this IObservable<double> observable, INumberEntityCore numberEntity, ILogger? logger = null) =>
        observable.Subscribe(x =>
        {
            logger?.LogInformation("Setting {EntityId} to {Target}", numberEntity.EntityId, x);
            numberEntity.SetValue(x.ToString(CultureInfo.InvariantCulture));
        });
}
