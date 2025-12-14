using System.Reactive.Concurrency;
using AwesomeNetdaemon.Features.Common;
using NetDaemon.HassModel.Entities;

namespace AwesomeNetdaemon.Features.BoilerControl;

public record BoilerThermostat
{
    public required Boiler Boiler { get; init; }
    public required RoomSettings[] Rooms { get; init; }
    public required NumericSensorEntity OutsideTemperatureSensor { get; init; }

    public void Run(IScheduler scheduler, ILogger logger)
    {
        var climates = Rooms.SelectMany(x => x.Climates).ToArray();
        ThrowHelper.ThrowIfDuplicate(climates);

        climates.Select(x => x.StateAllChangesWithCurrent()
                .Where(y => y.New?.Attributes != null))
            .CombineLatest()
            .Select(x => x.Any(y => y.New!.Attributes!.HvacAction != "idle"))
            .DistinctUntilChanged()
            .BindTo(Boiler.EnableEntity, logger);

        Rooms
            .Select(roomSettings => new Room
            {
                Pid = new PidController(logger)
                {
                    Name = roomSettings.Name,
                    Settings = roomSettings.PidSettings
                },
                Equitherm = new EquithermController
                {
                    Settings = roomSettings.EquithermSettings
                },
                Climates = roomSettings.Climates
            })
            .Select(room => room.Climates.Select(y => y.StateAllChangesWithCurrent()
                    .Where(state => state.New?.Attributes != null)
                    .Select(state => state.New!.Attributes!.Temperature!.Value - state.New!.Attributes!.CurrentTemperature!.Value)
                    .Select(x => x))
                .CombineLatest()
                .Select(errors => Math.Max(errors.Select(error => error).Max(), 0))
                .EmitLatestPeriodically(TimeSpan.FromMinutes(1), scheduler)
                .MovingAverage(5)
                .CombineLatest(OutsideTemperatureSensor.StateChangesWithCurrent()
                    .Select(x => x.New?.State ?? 0))
                .Select(x => room.Equitherm.GetHeatingCurveTemperature(x.Second) + room.Pid.Update(x.First, DateTime.Now.Ticks)))
            .CombineLatest()
            .Select(pidOutputs => pidOutputs.Max())
            .Clamp(Boiler.MinTemp, Boiler.MaxTemp)
            .DistinctUntilChanged()
            .BindTo(Boiler.SetPointEntity, logger);
    }
}


