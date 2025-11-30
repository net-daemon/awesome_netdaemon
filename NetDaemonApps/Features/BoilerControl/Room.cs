using AwesomeNetdaemon.Features.Common;

namespace AwesomeNetdaemon.Features.BoilerControl;

public record Room
{
    public required PidController Pid { get; init; }
    public required ClimateEntity[] Climates { get; init; }
}
