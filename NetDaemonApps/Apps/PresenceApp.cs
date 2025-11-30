using AwesomeNetdaemon.Features.Common;

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
