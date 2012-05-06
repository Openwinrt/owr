namespace Windows.Networking.NetworkOperators
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum MobileBroadbandAccountWatcherStatus
    {
        Created,
        Started,
        EnumerationCompleted,
        Stopped,
        Aborted
    }
}

