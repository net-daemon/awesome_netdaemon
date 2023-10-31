using NetDaemon.HassModel.Entities;

namespace AwesomeNetdaemon.Apps;

[NetDaemonApp]
public class PresenceApp
{
    public PresenceApp(IEntities entities)
    {
        entities.Person.Test
            .StateChanges()
            .Where(x => x.New.IsNotHome())
            .Subscribe(_ =>
            {
                // This could be some lights or your heating that you want to turn off when you leave your home.
                entities.InputBoolean.Toggle.TurnOff();
            });

        entities.Person.Test
            .StateChanges()
            .Where(x => x.New.IsHome())
            .Subscribe(_ =>
            {
                entities.InputBoolean.Toggle.TurnOn();
            });
    }
}

public static class PersonExtensions
{
    public static bool IsHome(this EntityState<PersonAttributes>? entityState) => string.Equals(entityState?.State, "home", StringComparison.OrdinalIgnoreCase);
    public static bool IsNotHome(this EntityState<PersonAttributes>? entityState) => !IsHome(entityState);
}
