namespace Windows.Devices.Enumeration
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum DeviceWatcherStatus
    {
        Created,
        Started,
        EnumerationCompleted,
        Stopping,
        Stopped,
        Aborted
    }
}

