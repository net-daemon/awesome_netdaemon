using AwesomeNetdaemon.Features.Common;

namespace AwesomeNetdaemon.Features.Interpolation;

public static class InterpolationExtensions
{
    public static int LinearInterpolate(this List<TimeBasedKeyframe> schedule, TimeSpan timeOfDay)
    {
        for (var i = 0; i < schedule.Count - 1; i++)
        {
            var a = schedule[i];
            var b = schedule[i + 1];

            if (timeOfDay >= a.Time && timeOfDay <= b.Time)
            {
                var total = (b.Time - a.Time).TotalMinutes;
                var elapsed = (timeOfDay - a.Time).TotalMinutes;
                var t = elapsed / total;
                return MathUtils.Lerp(a.Value, b.Value, t);
            }
        }

        return schedule.First().Value;
    }
}

public sealed record TimeBasedKeyframe(TimeSpan Time, int Value);
