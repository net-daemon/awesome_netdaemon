using System.Diagnostics.CodeAnalysis;
using System.Reactive.Concurrency;
using AwesomeNetdaemon.Services;
using AwesomeNetdaemon.Test.TestUtils;
using Microsoft.Extensions.DependencyInjection;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.HassModel;
using Xunit.DependencyInjection.Logging;

[assembly: ExcludeFromCodeCoverage]

namespace AwesomeNetdaemon.Test;

public static class Startup
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddLogging(x => x.AddXunitOutput());
        services.AddTransient<Entities>();
        services.AddTransient<IServices, HomeAssistantGenerated.Services>();
        services.AddNetDaemonScheduler();
        services.AddScoped<IHaContext, HaContextMockImpl>();
        services.AddScoped<TestScheduler>();
        services.AddTransient<IScheduler>(s => s.GetRequiredService<TestScheduler>());
        services.AddTransient<StateChangeManager>();
        services.AddTransient<TestEntityBuilder>();
        services.AddTransient<DetectProgramByPowerUsageBuilder>();
        services.AddTransient<DetectProgramByPowerUsageBuilderFactory>();
    }
}
