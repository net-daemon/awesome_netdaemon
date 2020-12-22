using System;
using System.Reactive.Linq;

using NetDaemon.Common.Reactive;

namespace PersistantApp
{

    /// <summary>
    ///      App that tests persistant storage
    /// </summary>
    public class PersistantApp : PersistantStateAppBase
    {
        public override void Initialize()
        {
            int? counter = (int?)GetPersistentState("counter");
            if (counter is null)
                SetPersistentState("counter", 1);
            else
                SetPersistentState("counter", counter + 1);

            Log("The counter has count {counter}", counter ?? 0);
        }
    }
}