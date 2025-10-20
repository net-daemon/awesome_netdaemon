using AwesomeNetdaemon.Features.Interpolation;
using NetDaemon.HassModel.Entities;

namespace AwesomeNetdaemon.Features.Lights;

public static class CircadianSchedules
{
    public static IObservable<List<TimeBasedKeyframe>> ConstantSchedule() =>
        Observable.Return(new List<TimeBasedKeyframe>
        {
            new(TimeSpan.FromHours(7), 2200),
            new(TimeSpan.FromHours(9), 4000),
            new(TimeSpan.FromHours(13), 4500),
            new(TimeSpan.FromHours(18), 4000),
            new(TimeSpan.FromHours(20), 2200)
        });

    public static IObservable<List<TimeBasedKeyframe>> SunBasedSchedule(SunEntity sunEntity) =>
        sunEntity.StateAllChangesWithCurrent()
            .Where(x => x.New?.Attributes != null)
            .Select(x => x.New!.Attributes!)
            .Select(x =>
            {
                var format = "yyyy-MM-ddTHH:mm:ss.ffffffK";
                var noonFormat = "yyyy-MM-ddTHH:mm:ssK";
                return new SunData(
                    DateTimeOffset.ParseExact(x.NextRising!, format, null).LocalDateTime.TimeOfDay,
                    DateTimeOffset.ParseExact(x.NextDawn!, format, null).LocalDateTime.TimeOfDay,
                    DateTimeOffset.ParseExact(x.NextNoon!, noonFormat, null).LocalDateTime.TimeOfDay,
                    DateTimeOffset.ParseExact(x.NextSetting!, format, null).LocalDateTime.TimeOfDay,
                    DateTimeOffset.ParseExact(x.NextDusk!, format, null).LocalDateTime.TimeOfDay);
            })
            .DistinctUntilChanged()
            .Select(sunData =>
            {
                var morningRamp = sunData.NextRising * 2 - sunData.NextDawn;
                var eveningRamp = sunData.NextSetting * 2 - sunData.NextDusk;
                return new List<TimeBasedKeyframe>
                {
                    new(sunData.NextDawn, 2200),
                    new(sunData.NextRising, 3500),
                    new(morningRamp, 4000),
                    new(sunData.NextNoon, 4500),
                    new(eveningRamp, 4000),
                    new(sunData.NextSetting, 3500),
                    new(sunData.NextDusk, 2200)
                };
            });

    private sealed record SunData(TimeSpan NextRising, TimeSpan NextDawn, TimeSpan NextNoon, TimeSpan NextSetting, TimeSpan NextDusk);
}
