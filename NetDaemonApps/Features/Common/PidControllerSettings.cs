namespace AwesomeNetdaemon.Features.Common;

public record PidControllerSettings
{
    /// <summary>
    ///     The time over which the integral term accumulates error before it decays so much to be insignificant.
    /// </summary>
    public double IntegrationTime { get; init; } = TimeSpan.FromMinutes(30).TotalMinutes;

    /// <summary>
    ///     The time after which the dt is considered to equal to 1.
    /// </summary>
    public TimeSpan TimeFactor { get; init; } = TimeSpan.FromMinutes(1);

    /// <summary>
    ///     Determine how responsive the controller is to the rate of change of the error.
    /// </summary>
    public required double Kd { get; init; }

    /// <summary>
    ///     Determine how strongly the controller responds to the accumulation of past errors.
    /// </summary>
    public required double Ki { get; init; }

    /// <summary>
    ///     Determine how strongly the controller responds to the current error.
    /// </summary>
    public required double Kp { get; init; }

    /// <summary>
    ///     A constant value added to the output.
    /// </summary>
    public required double Bias { get; init; }
}
