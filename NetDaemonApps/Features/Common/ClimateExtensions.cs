using NetDaemon.HassModel.Entities;

namespace AwesomeNetdaemon.Features.Common;

public static class ClimateExtensions
{
    public static IObservable<ClimateSetParameters> ToClimateSetTemperatureParameters(this ScheduleEntity schedule) =>
        schedule.StateAllChangesWithCurrent()
            .Select(x => x.New?.Attributes?.Value)
            .Select(temperature =>
            {
                if (temperature == null) return ClimateSetParameters.DefaultOff;

                return new ClimateSetParameters
                {
                    Temperature = temperature
                };
            });

    public static IObservable<ClimateSetParameters> OverrideIfAllNotPresent(this IObservable<ClimateSetParameters> observable,
        ClimateSetParameters parameters,
        params PersonEntity[] persons) =>
        observable.CombineLatest(persons.Select(x => x
                    .StateChangesWithCurrent()
                    .Select(y => y.New.IsHome()))
                .CombineLatest()
                .Select(x => x.Contains(true)))
            .Select(x => x.Second ? x.First : parameters);

    public static void BindToClimate(this IObservable<ClimateSetParameters> observable, ClimateEntity climate) => observable.Subscribe(climate.SetClimateParameters);

    public static void BindToClimate(this IObservable<ClimateSetParameters> observable, params ClimateEntity[] climates) =>
        observable.Subscribe(x =>
        {
            foreach (var climate in climates) climate.SetClimateParameters(x);
        });

    private static void SetClimateParameters(this ClimateEntity climate, ClimateSetParameters parameters)
    {
        if (parameters.Temperature != null) climate.SetTemperature(parameters.Temperature);

        if (parameters.HvacMode != null) climate.SetHvacMode(parameters.HvacMode);
    }
}
