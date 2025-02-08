using NetDaemon.HassModel.Entities;

namespace AwesomeNetdaemon.Test.TestUtils;

public static class HomeAssistantEvents
{
    public static object ExpectTurnOffEvent(this ILightEntityCore entity) =>
        new
        {
            Domain = "light",
            Service = "turn_off",
            Target = new
            {
                EntityIds = new[] { entity.EntityId }
            }
        };

    public static object ExpectTurnOnEvent(this ILightEntityCore entity) =>
        new
        {
            Domain = "light",
            Service = "turn_on",
            Target = new
            {
                EntityIds = new[] { entity.EntityId }
            }
        };

    public static object ExpectTurnOnEvent(this ISceneEntityCore entity) =>
        new
        {
            Domain = "scene",
            Service = "turn_on",
            Target = new
            {
                EntityIds = new[] { entity.EntityId }
            }
        };

    public static object ExpectTurnOnEvent(this InputBooleanEntity entity) =>
        new
        {
            Domain = "input_boolean",
            Service = "turn_on",
            Target = new
            {
                EntityIds = new[] { entity.EntityId }
            }
        };

    public static object ExpectTurnOffEvent(this InputBooleanEntity entity) =>
        new
        {
            Domain = "input_boolean",
            Service = "turn_off",
            Target = new
            {
                EntityIds = new[] { entity.EntityId }
            }
        };

    public static object ExpectHvacModeAutoEvent(this IClimateEntityCore entity) =>
        new
        {
            Data = new
            {
                HvacMode = "auto"
            },
            Domain = "climate",
            Service = "set_hvac_mode",
            Target = new
            {
                EntityIds = new[] { entity.EntityId }
            }
        };

    public static object ExpectHvacModeOffEvent(this IClimateEntityCore entity) =>
        new
        {
            Data = new
            {
                HvacMode = "off"
            },
            Domain = "climate",
            Service = "set_hvac_mode",
            Target = new
            {
                EntityIds = new[] { entity.EntityId }
            }
        };
}
