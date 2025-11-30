using System.Reactive.Concurrency;
using AwesomeNetdaemon.Features.Common;
using NetDaemon.HassModel.Entities;

namespace AwesomeNetdaemon.Features.BoilerControl;

public record BoilerThermostat
{
    public required Boiler Boiler { get; init; }
    public required RoomSettings[] Rooms { get; init; }

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
            .Select(x => new Room
            {
                Pid = new PidController { Settings = x.PidSettings },
                Climates = x.Climates
            })
            .Select(x => x.Climates.Select(y => y.StateAllChangesWithCurrent()
                    .Where(z => z.New?.Attributes != null)
                    .Select(z => z.New!.Attributes!.Temperature!.Value - z.New!.Attributes!.CurrentTemperature!.Value))
                .CombineLatest()
                .Select(y => y.Max())
                .Select(y => (x.Pid, Error: y))
                .EmitLatestPeriodically(TimeSpan.FromMinutes(1), scheduler)
                .Select(y => y.Pid.Update(y.Error, logger)))
            .CombineLatest()
            .Select(x => x.Max())
            .Clamp(Boiler.MinTemp, Boiler.MaxTemp)
            .DistinctUntilChanged()
            .BindTo(Boiler.SetPointEntity, logger);
    }
}
