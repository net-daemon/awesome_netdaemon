using NetDaemon.HassModel;
using NetDaemon.HassModel.Entities;

namespace AwesomeNetdaemon.Test.TestUtils;

public class HaRegistryMockImpl : IHaRegistry
{
    public EntityRegistration? GetEntityRegistration(string entityId) => Entities.FirstOrDefault(x => x.Id == entityId);

    public Device? GetDevice(string deviceId) => Devices.FirstOrDefault(x => x.Id == deviceId);

    public Area? GetArea(string areaId) => Areas.FirstOrDefault(x => x.Id == areaId);

    public Floor? GetFloor(string floorId) => Floors.FirstOrDefault(x => x.Id == floorId);

    public Label? GetLabel(string labelId) => Labels.FirstOrDefault(x => x.Id == labelId);

    public IReadOnlyCollection<EntityRegistration> Entities { get; } = [];

    public IReadOnlyCollection<Device> Devices { get; } = [];

    public IReadOnlyCollection<Area> Areas { get; } = [];

    public IReadOnlyCollection<Floor> Floors { get; } = [];

    public IReadOnlyCollection<Label> Labels { get; } = [];
}
