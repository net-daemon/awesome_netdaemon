using AwesomeNetdaemon.Features.Common;

namespace AwesomeNetdaemon.Features.BoilerControl;

public record RoomSettings
{
    public required PidControllerSettings PidSettings { get; init; }
    public required ClimateEntity[] Climates { get; init; }
}
