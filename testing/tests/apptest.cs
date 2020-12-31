using System;
using System.Linq;
using System.Reactive.Linq;
using Moq;
using NetDaemon.Daemon.Fakes;
using Xunit;
using NetDaemon.Common.Reactive;
using HelloWorld;

namespace Tests.Test
{
    /// <summary>
    ///     Tests the apps
    /// </summary>
    public class AppTests : RxAppMock
    {
        [Fact]
        public void TestFakeMockableBinarySensorApp()
        {
            // ARRANGE
            HelloWorldImplementation app = new(Object);
            app.Initialize();

            // ACT
            TriggerStateChange("binary_sensor.pir_kitchen", "off", "on");

            // ASSERT
            VerifyEntityTurnOn("light.somelight");
        }
    }
}