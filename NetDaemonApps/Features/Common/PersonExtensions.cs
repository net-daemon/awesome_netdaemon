using NetDaemon.HassModel.Entities;

namespace AwesomeNetdaemon.Features.Common;

public static class PersonExtensions
{
    public static bool IsHome(this EntityState<PersonAttributes>? entityState) => string.Equals(entityState?.State, "home", StringComparison.OrdinalIgnoreCase);
    public static bool IsNotHome(this EntityState<PersonAttributes>? entityState) => !IsHome(entityState);
}
