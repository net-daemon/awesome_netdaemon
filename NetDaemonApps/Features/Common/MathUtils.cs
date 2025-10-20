namespace AwesomeNetdaemon.Features.Common;

public static class MathUtils
{
    public static double Lerp(double a, double b, double t)
        => a + (b - a) * Math.Clamp(t, 0.0, 1.0);

    public static int Lerp(int a, int b, double t)
        => (int)Math.Round(a + (b - a) * Math.Clamp(t, 0.0, 1.0));

    public static bool IsDifferent(double? current, int target, double tolerance = 50)
    {
        if (current == null)
            return true;

        return Math.Abs(current.Value - target) > tolerance;
    }
}
