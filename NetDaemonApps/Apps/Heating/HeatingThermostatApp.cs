using System.Reactive.Concurrency;
using AwesomeNetdaemon.Features.BoilerControl;

namespace AwesomeNetdaemon.Apps.Heating;

[NetDaemonApp]
public class HeatingThermostatApp
{
    public HeatingThermostatApp(IEntities entities, IServices services, IScheduler scheduler, ILogger<HeatingThermostatApp> logger)
    {
        // This is an example heating app that sets up an equitherm + PID based boiler thermostat with multi room support.
        var pidSettings = new PidControllerSettings
        {
            Kp = 3.0, // Controls how strongly the boiler reacts to the current error (difference between desired and actual temperature).
            Ki = 0.15, // Controls how strongly the boiler reacts to the accumulated error over time, helping to eliminate steady-state error.
            Kd = 0.0, // Controls how strongly the boiler reacts to the rate of change of the error, helping to dampen oscillations. Usually not needed for slow heating systems like home heating.
        };
        var equithermSettings = new EquithermSettings
        {
            M = -1.4, // Slope of the heating curve, determining how much the boiler temperature increases as the outside temperature drops.
            B = 55 // Base temperature when the outside temperature is 0°C, setting the baseline for the heating curve.
        };
        var thermostat = new BoilerThermostat
        {
            Rooms =
            [
                new RoomSettings
                {
                    Name = "Woonkamer",
                    PidSettings = pidSettings,
                    EquithermSettings = equithermSettings,
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
            },
            OutsideTemperatureSensor = entities.Sensor.OutsideTemperature
        };
        thermostat.Run(scheduler, logger);
    }
}
