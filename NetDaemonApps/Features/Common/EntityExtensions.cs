namespace AwesomeNetdaemon.Features.Common;

public static class EntityExtensions
{
    public static bool HasDeviceClass(this NumericSensorEntity entity, string deviceClass) => entity.Attributes?.DeviceClass == deviceClass;
}
