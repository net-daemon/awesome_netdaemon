using System;
using System.Reactive.Linq;

using NetDaemon.Common.Reactive;

namespace PersistentApp
{

    /// <summary>
    ///      App that tests persistent storage
    /// </summary>
    public class PersistentApp : PersistentStateAppBase
    {
        public override void Initialize()
        {
            RunEvery(TimeSpan.FromSeconds(1), () =>
            {
                int? counter = (int?)GetPersistentState("counter");
                if (counter is null)
                    SetPersistentState("counter", 1);
                else
                    SetPersistentState("counter", counter + 1);

                Log("The counter has count {counter}", counter ?? 0);
            });

        }
    }
}