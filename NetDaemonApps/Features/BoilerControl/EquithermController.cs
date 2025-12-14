namespace AwesomeNetdaemon.Features.BoilerControl;

public class EquithermController
{
    public required EquithermSettings Settings { get; init; }

    public double GetHeatingCurveTemperature(double outsideTemperature) => Settings.M * outsideTemperature + Settings.B;
}
