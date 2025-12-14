namespace AwesomeNetdaemon.Features.BoilerControl;

public class PidController(ILogger logger)
{
    private double _integral;
    private double _lastError;
    private long? _lastTime;

    public required string Name { get; init; }
    public required PidControllerSettings Settings { get; init; }

    public double Update(double error, long now)
    {
        var dt = _lastTime.HasValue ? (double)(now - _lastTime.Value) / Settings.TimeFactor : 0.0;
        _lastTime = now;

        var derivative = 0.0;
        if (dt > 0) derivative = (error - _lastError) / dt;

        if (dt > 0)
        {
            var decay = Math.Exp(-dt / Settings.IntegrationTime);
            var denom = 1.0 - Math.Exp(-1.0);
            var scale = Settings.IntegrationTime / dt * (1.0 - decay) / denom;

            _integral = _integral * decay + error * dt * scale;
        }

        _lastError = error;

        var kpPart = Settings.Kp * error;
        var kiPart = Settings.Ki * _integral;
        var kdPart = Settings.Kd * derivative;
        var output = kpPart + kiPart + kdPart;

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
