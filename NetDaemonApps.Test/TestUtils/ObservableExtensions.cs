namespace AwesomeNetdaemon.Test.TestUtils;

public static class ObservableExtensions
{
    public static IDisposable SubscribeAndCapture<T>(this IObservable<T> source, out List<T> invokes) => source.Subscribe(Capture<T>(out invokes));

    private static Action<T> Capture<T>(out List<T> detectedPrograms)
    {
        detectedPrograms = [];
        var list = detectedPrograms;
        return x => list.Add(x);
    }
}
