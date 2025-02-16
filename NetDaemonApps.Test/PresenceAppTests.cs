﻿using AwesomeNetdaemon.Apps;
using AwesomeNetdaemon.Test.TestUtils;

namespace AwesomeNetdaemon.Test;

public class PresenceAppTests(Entities entities, StateChangeManager state)
{
    [Fact]
    public void IsHome()
    {
        _ = new PresenceApp(entities);

        state
            .Change(entities.Person.Test, "home");

        state.ServiceCalls.Should().BeEquivalentTo([
            entities.InputBoolean.Toggle.ExpectTurnOnEvent()
        ]);
    }

    [Fact]
    public void IsNotHome()
    {
        _ = new PresenceApp(entities);

        state
            .Change(entities.Person.Test, "not_home");

        state.ServiceCalls.Should().BeEquivalentTo([
            entities.InputBoolean.Toggle.ExpectTurnOffEvent()
        ]);
    }
}
