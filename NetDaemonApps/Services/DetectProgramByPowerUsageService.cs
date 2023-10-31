using System.Reactive.Concurrency;

namespace AwesomeNetdaemon.Services;

public class DetectProgramByPowerUsageService(IScheduler scheduler, ILogger<DetectProgramByPowerUsageService> logger)
{
    public IObservable<DetectedProgram> GenerateObservable(NumericSensorEntity currentPowerSensor, NumericSensorEntity totalPowerSensor, Func<double, bool> activeProgramFunc) =>
        currentPowerSensor
            .StateChanges()
            .NotNull()
            .CombineLatest(totalPowerSensor
                .StateChanges()
                .NotNull()
                .Select(x => x.New?.State ?? 0)
                .Prepend(totalPowerSensor.State ?? 0))
            .Select(x => (ProgramActive: activeProgramFunc(x.First.New!.State!.Value), TotalPower: x.Second))
            .Timestamp(scheduler)
            .DistinctUntilChanged(x => x.Value.ProgramActive)
            .PairWithPrevious()
            .Do(x =>
            {
                if (x.Current.Value.ProgramActive)
                {
                    logger.LogInformation("Detected start of program for {EntityId}, current total energy: {TotalEnergy}", currentPowerSensor.EntityId, x.Current.Value.TotalPower);
                }
            })
            .Where(x => x.Current.Value.ProgramActive == false && x.Previous.Value.ProgramActive)
            .Do(x => logger.LogInformation("Detected end of program for {EntityId}, current total energy: {TotalEnergy}", currentPowerSensor.EntityId, x.Current.Value.TotalPower))
            .Select(x => new DetectedProgram(x.Current.Timestamp - x.Previous.Timestamp, x.Current.Value.TotalPower - x.Previous.Value.TotalPower));
}
