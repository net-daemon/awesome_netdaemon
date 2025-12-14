namespace AwesomeNetdaemon.Features.BoilerControl;

public record RoomSettings
{
    public required string Name { get; init; }
    public required PidControllerSettings PidSettings { get; init; }
    public required EquithermSettings EquithermSettings { get; init; }
    public required ClimateEntity[] Climates { get; init; }
}
