using System.Reactive.Concurrency;
using AwesomeNetdaemon.Features.Common;
using AwesomeNetdaemon.Features.Interpolation;
using NetDaemon.HassModel.Entities;

namespace AwesomeNetdaemon.Features.Lights;

public static class ObservableExtensions
{
    public static void BindToLight(this IObservable<(bool on, LightTurnOnParameters parameters)> observable, ILightEntityCore light) =>
        observable.Subscribe(x =>
        {
            if (x.on)
                light.TurnOn(x.parameters);
            else
                light.TurnOff(10);
        });

    public static void BindToLight(this IObservable<bool> observable, ILightEntityCore light) =>
        observable.Subscribe(x =>
        {
            if (x)
                light.TurnOn(0, brightnessPct: 100);
            else
                light.TurnOff(10);
        });

    public static IObservable<(bool on, LightTurnOnParameters parameters)> WithLightParameters(this IObservable<bool> observable, LightTurnOnParameters parameters) =>
        observable.CombineLatest(Observable.Return(parameters));

    public static IObservable<(bool on, LightTurnOnParameters parameters)> WithBrightnessSchedule(this IObservable<bool> observable,
        IScheduler scheduler,
        IObservable<List<TimeBasedKeyframe>> nightLightSchedule) =>
        observable
            .Select(x => (x, new LightTurnOnParameters { BrightnessPct = 100, Transition = 1 }))
            .WithBrightnessSchedule(scheduler, nightLightSchedule);

    public static IObservable<(bool on, LightTurnOnParameters parameters)> WithBrightnessSchedule(this IObservable<(bool on, LightTurnOnParameters parameters)> observable,
        IScheduler scheduler,
        IObservable<List<TimeBasedKeyframe>> nightLightSchedule)
    {
        var brightNessObservable = Observable.Interval(TimeSpan.FromMinutes(1), scheduler)
            .Prepend(0)
            .CombineLatest(nightLightSchedule)
            .Select(x => x.Second.LinearInterpolate(scheduler.Now.LocalDateTime.TimeOfDay))
            .DistinctUntilChanged();

        return observable
            .CombineLatest(brightNessObservable)
            .Select(x => (x.First.on, x.First.parameters with { BrightnessPct = x.Second }));
    }

    public static IObservable<(bool on, LightTurnOnParameters parameters)> WithColorTempSchedule(this IObservable<bool> observable,
        IScheduler scheduler,
        IObservable<List<TimeBasedKeyframe>> circadianSchedule)
    {
        var colorTempObservable = Observable.Interval(TimeSpan.FromMinutes(1), scheduler)
            .Prepend(0)
            .CombineLatest(circadianSchedule)
            .Select(x => GetLightParameters(x.Second))
            .DistinctUntilChanged();

        return observable.CombineLatest(colorTempObservable);

        LightTurnOnParameters GetLightParameters(List<TimeBasedKeyframe> schedule)
        {
            return new LightTurnOnParameters
            {
                BrightnessPct = 100,
                ColorTempKelvin = schedule.LinearInterpolate(scheduler.Now.LocalDateTime.TimeOfDay),
                Transition = 1
            };
        }
    }

    public static void SyncColorTempWithSchedule(this LightEntity light, IScheduler scheduler, IObservable<List<TimeBasedKeyframe>> circadianSchedule)
    {
        light.StateChanges()
            .CombineLatest(circadianSchedule)
            .Where(x => x.First.New.IsOn())
            .Where(x => MathUtils.IsDifferent(x.First.New?.Attributes?.ColorTempKelvin, x.Second.LinearInterpolate(scheduler.Now.LocalDateTime.TimeOfDay)))
            .Subscribe(x =>
            {
                var (_, schedule) = x;
                light.TurnOn(new LightTurnOnParameters { ColorTempKelvin = schedule.LinearInterpolate(scheduler.Now.LocalDateTime.TimeOfDay), Transition = 1 });
            });

        Observable.Interval(TimeSpan.FromMinutes(1), scheduler)
            .CombineLatest(circadianSchedule)
            .Select(x =>
            {
                var (_, schedule) = x;
                return schedule.LinearInterpolate(scheduler.Now.LocalDateTime.TimeOfDay);
            })
            .Subscribe(cct =>
            {
                if (light.IsOn() && MathUtils.IsDifferent(light.Attributes?.ColorTempKelvin, cct)) light.TurnOn(new LightTurnOnParameters { ColorTempKelvin = cct, Transition = 1 });
            });
    }
}
