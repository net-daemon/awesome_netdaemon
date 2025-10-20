using AwesomeNetdaemon.Features.Interpolation;

namespace AwesomeNetdaemon.Features.Lights;

public static class NightLightSchedules
{
    public static IObservable<List<TimeBasedKeyframe>> ConstantSchedule() =>
        Observable.Return(new List<TimeBasedKeyframe>
        {
            new(TimeSpan.FromHours(6), 25),
            new(TimeSpan.FromHours(8), 100),
            new(TimeSpan.FromHours(20), 100),
            new(TimeSpan.FromHours(22), 25)
        });
}
