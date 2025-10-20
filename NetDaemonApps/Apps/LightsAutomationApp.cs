using System.Reactive.Concurrency;
using AwesomeNetdaemon.Features.Lights;
using static AwesomeNetdaemon.Features.Builders.Builders;

namespace AwesomeNetdaemon.Apps;

[NetDaemonApp]
public class LightsAutomationApp
{
    public LightsAutomationApp(IEntities entities, IScheduler scheduler, ILogger<LightsAutomationApp> logger)
    {
        // This is an example of how to set up an advanced motion sensor based lighting automation using Netdaemon features. This particular example uses extra abstractions to keep the automation code concise.
        SensorObservableBuilder()
            // We want our motion sensor to turn on the light.
            .WithSensor(entities.BinarySensor._1eHalMotionSensorOccupancy)
            // If its too bright (> 110) then we want to keep the light off even if motion is detected by giving it a higher off priority. We use hysteresis to avoid flickering.
            .WithSensor(entities.Sensor._1eHalMotionSensorIlluminance, c => c.WithHysteresis(80, 110).WithOffPriority(1))
            .ToObservable()
            // We want the color temperature to follow a circadian rhythm based on the sun position.
            .WithColorTempSchedule(scheduler, CircadianSchedules.SunBasedSchedule(entities.Sun.Sun))
            // We want to dim the lights at night based on a predefined schedule.
            .WithBrightnessSchedule(scheduler, NightLightSchedules.ConstantSchedule())
            // Finally we bind the resulting observable to the light entity.
            .BindToLight(entities.Light._1eHalLampen);
    }
}
