namespace AwesomeNetdaemon.Features.BoilerControl;

public record PidControllerSettings
{
    /// <summary>
    ///     The time over which the integral term accumulates error before it decays so much to be insignificant.
    /// </summary>
    public long IntegrationTime { get; init; } = 30;

    /// <summary>
    ///     The time after which the dt is considered to equal to 1.
    /// </summary>
    public long TimeFactor { get; init; } = TimeSpan.FromMinutes(1).Ticks;

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
}
