using System.Collections.ObjectModel;
using System.Globalization;
using NetDaemon.HassModel;
using NetDaemon.HassModel.Entities;

namespace AwesomeNetdaemon.Test.TestUtils;

public class StateChangeManager(IHaContext haContextMock, TestScheduler testScheduler)
{
    public ReadOnlyCollection<TestServiceCall> ServiceCalls => new(((HaContextMockImpl)haContextMock).ServiceCalls);

    /// <summary>
    ///     Clears the tracked list of service calls. Handy if you only want to assert on a subset of the calls.
    /// </summary>
    /// <returns></returns>
    public StateChangeManager ClearTrackedServiceCalls()
    {
        ((HaContextMockImpl)haContextMock).ServiceCalls.Clear();
        return this;
    }

    public StateChangeManager Change(IEntityCore entity, string newStatevalue, object? attributes = null)
    {
        ((HaContextMockImpl)haContextMock).TriggerStateChange(entity, newStatevalue, attributes);
        return this;
    }

    public StateChangeManager Change(ISensorEntityCore entity, double newStatevalue, object? attributes = null) => Change(entity, newStatevalue.ToString(CultureInfo.InvariantCulture), attributes);

    public StateChangeManager AdvanceTo(DateTime dateTime)
    {
        testScheduler.AdvanceTo(dateTime.ToUniversalTime().Ticks);
        return this;
    }

    public StateChangeManager AdvanceTo(TimeOnly timeOnly)
    {
        testScheduler.AdvanceTo(new DateTime(DateOnly.FromDateTime(testScheduler.Now.Date), timeOnly).ToUniversalTime().Ticks);
        return this;
    }

    public StateChangeManager AdvanceTo(DateOnly dateOnly)
    {
        testScheduler.AdvanceTo(new DateTime(dateOnly, TimeOnly.FromDateTime(testScheduler.Now.DateTime)).ToUniversalTime().Ticks);
        return this;
    }

    public StateChangeManager AdvanceDays(int days)
    {
        testScheduler.AdvanceBy(TimeSpan.FromDays(days).Ticks);
        return this;
    }
}
