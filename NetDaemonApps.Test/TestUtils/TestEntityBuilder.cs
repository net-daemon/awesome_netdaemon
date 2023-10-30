using NetDaemon.HassModel;

namespace MyNetdaemonSmarthome.Test.TestUtils;

public class TestEntityBuilder(IHaContext haContext)
{
    public NumericSensorEntity CreateNumericEntity(string entityId) => new(haContext, entityId);
    public LightEntity CreateLightEntity(string entityId) => new(haContext, entityId);
    public PersonEntity CreatePersonEntity(string entityId) => new(haContext, entityId);
}
