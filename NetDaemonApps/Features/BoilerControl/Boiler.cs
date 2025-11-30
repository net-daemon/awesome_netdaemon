namespace AwesomeNetdaemon.Features.BoilerControl;

public record Boiler
{
    public required double MinTemp { get; init; }
    public required double MaxTemp { get; init; }
    public required NumberEntity SetPointEntity { get; init; }
    public required SwitchEntity EnableEntity { get; init; }
}
