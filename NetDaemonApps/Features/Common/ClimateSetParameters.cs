using System.Text.Json.Serialization;

namespace AwesomeNetdaemon.Features.Common;

public record ClimateSetParameters
{
    public static readonly ClimateSetParameters DefaultOff = new()
    {
        HvacMode = "off"
    };

    [JsonPropertyName("temperature")]
    public double? Temperature { get; init; }

    [JsonPropertyName("hvac_mode")]
    public object? HvacMode { get; init; }
}
