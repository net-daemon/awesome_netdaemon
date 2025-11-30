using System.Reactive.Concurrency;
using AwesomeNetdaemon.Features.BoilerControl;
using AwesomeNetdaemon.Features.Common;

namespace AwesomeNetdaemon.Apps;

[NetDaemonApp]
public class HeatingApp
{
    public HeatingApp(IEntities entities, IServices services, IScheduler scheduler, ILogger<HeatingApp> logger)
    {
        // This is an example heating app that sets up a PID based boiler thermostat to control heating based on room climates.
        var pidSettings = new PidControllerSettings
        {
            Kp = 5.0, // Controls how strongly the controller reacts to the current error.
            Ki = 0.2, // Controls how strongly the controller reacts to the accumulated error over time.
            Kd = 0.0, // Controls how strongly the controller reacts to the rate of change of the error. Usually not relevant for heating systems.
            Bias = 45.0 // Base output value to ensure the boiler operates within a reasonable range.
        };
        var thermostat = new BoilerThermostat
        {
            Rooms =
            [
                new RoomSettings
                {
                    PidSettings = pidSettings,
                    Climates =
                    [
                        entities.Climate.BeganegrondWoonkamerRadiator
                    ]
                }
            ],
            Boiler = new Boiler
            {
                MinTemp = 30.0,
                MaxTemp = 80.0,
                SetPointEntity = entities.Number.OpenthermThermostatTSet,
                EnableEntity = entities.Switch.OpenthermThermostatChEnable
            }
        };
        thermostat.Run(scheduler, logger);
    }
}
