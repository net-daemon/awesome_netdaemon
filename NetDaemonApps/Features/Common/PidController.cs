namespace AwesomeNetdaemon.Features.Common;

public class PidController
{
    private double _integral;
    private double _lastError;
    private DateTime? _lastTime;

    public required string Name { get; init; }
    public required PidControllerSettings Settings { get; init; }

    public double Update(double error, ILogger logger)
    {
        var now = DateTime.UtcNow;
        var dt = _lastTime.HasValue ? (double)(now - _lastTime.Value).Ticks / Settings.TimeFactor.Ticks : 0.0;
        _lastTime = now;

        var derivative = 0.0;
        if (dt > 0) derivative = (error - _lastError) / dt;

        _integral += error * dt;

        if (dt > 0)
        {
            var decay = Math.Exp(-dt / Settings.IntegrationTime);
            _integral = _integral * decay + error * dt;
        }

        _lastError = error;

        var kpPart = Settings.Kp * error;
        var kiPart = Settings.Ki * _integral;
        var kdPart = Settings.Kd * derivative;
        var output = kpPart + kiPart + kdPart + Settings.Bias;

        logger.LogInformation("PID Update for {Name} - Error: {Error}, Output: {Output}, P: {P}, I: {I}, D: {D}, dt: {Dt}",
            Name,
            error,
            output,
            kpPart,
            kiPart,
            kdPart,
            dt);

        return output;
    }
}
