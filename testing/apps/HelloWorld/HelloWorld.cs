using System;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;

// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names
namespace HelloWorld
{
    /// <summary>
    ///     Hello world showcase
    /// </summary>
    public class HelloWorldApp : NetDaemonRxApp
    {
        private readonly HelloWorldImplementation _app;

        public HelloWorldApp()
        {
            _app = new HelloWorldImplementation(this);
        }
        public override void Initialize()
        {
            _app.Initialize();
        }
    }

    public class HelloWorldImplementation
    {
        private readonly INetDaemonRxApp app;
        public HelloWorldImplementation(INetDaemonRxApp x)
        {
            app = x;
        }

        public void Initialize()
        {
            app.Entity("binary_sensor.pir_kitchen")
                .StateChanges
                .Where(e => e.New?.State == "on")
                .Subscribe(_ => app.Entity("light.somelight").TurnOn());
        }
    }
}
