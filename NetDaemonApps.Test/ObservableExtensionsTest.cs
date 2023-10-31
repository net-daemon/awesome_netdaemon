using System.Reactive.Linq;
using AwesomeNetdaemon.Test.TestUtils;

namespace AwesomeNetdaemon.Test;

public class ObservableExtensionsTest
{
    [Fact]
    public void MovingAverage()
    {
        //Arrange
        var observable = new double[] { 1, 2, 3, 4, 7, 6 }.ToObservable();

        //Act
        _ = observable.MovingAverage(3).SubscribeAndCapture(out var results);

        //Assert
        results.Should().BeEquivalentTo(new[]
        {
            1,
            (1 + 2) / 2d,
            (1 + 2 + 3) / 3d,
            (2 + 3 + 4) / 3d,
            (3 + 4 + 7) / 3d,
            (4 + 7 + 6) / 3d
        });
    }

    [Fact]
    public void TriggerAndWait()
    {
        //Arrange
        var observable = new[] { 8, 8, 1.02, 1, 1, 1, 5, 5, 5, 1.54 }
            .ToObservable();

        //Act
        observable
            .TriggerAndWait(x => x < 2, x => x > 2)
            .SubscribeAndCapture(out var results);

        //Assert
        results.Should().BeEquivalentTo(new[] { 1.02, 1.54 });
    }
}
