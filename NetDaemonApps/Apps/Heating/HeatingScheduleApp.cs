using System.Reactive.Concurrency;
using AwesomeNetdaemon.Features.Common;

namespace AwesomeNetdaemon.Apps.Heating;

[NetDaemonApp]
public class HeatingScheduleApp
{
    public HeatingScheduleApp(IEntities entities, IServices services, IScheduler scheduler, ILogger<HeatingScheduleApp> logger)
    {
        entities.Schedule.WoonkamerHeating
             // Converts the schedule to an observable of climate set temperature parameters. Assumes the schedule has a value property in additional data for the desired temperature.
            .ToClimateSetTemperatureParameters()
             // Overrides the schedule settings to turn off the heating when the specified person is not home.
            .OverrideIfAllNotPresent(ClimateSetParameters.DefaultOff, entities.Person.Test)
             // Binds the resulting observable to the specified climate entity to control its temperature.
            .BindToClimate(entities.Climate.BeganegrondWoonkamerRadiator);
    }
}
