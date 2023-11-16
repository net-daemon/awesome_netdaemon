using System.Reflection;
using AwesomeNetdaemon.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using NetDaemon.Extensions.Logging;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.Runtime;

#pragma warning disable CA1812

try
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Host
        .UseNetDaemonDefaultLogging()
        .UseNetDaemonRuntime();

    builder.Services.AddHealthChecks();
    builder.Services.AddRouting();
    builder.Services
        .AddAppsFromAssembly(Assembly.GetExecutingAssembly())
        .AddNetDaemonStateManager()
        .AddNetDaemonScheduler()
        .AddHomeAssistantGenerated()
        .AddTransient<IEntities, Entities>()
        .AddTransient<IServices, Services>()
        .AddTransient<DetectProgramByPowerUsageBuilder>()
        .AddTransient<DetectProgramByPowerUsageBuilderFactory>();

    var app = builder.Build();

    app.MapGet("/healthcheck", () => "its working");

    await app.RunAsync()
        .ConfigureAwait(false);
}
catch (Exception e)
{
    Console.WriteLine($"Failed to start host... {e}");
    throw;
}
