namespace MyNetdaemonSmarthome.Test.TestUtils;

public static class Events
{
    public static class Light
    {
        public static object TurnOff(LightEntity entity) =>
            new
            {
                Domain = "light",
                Service = "turn_off",
                Target = new
                {
                    EntityIds = new[] { entity.EntityId }
                },
            };
    }
}
