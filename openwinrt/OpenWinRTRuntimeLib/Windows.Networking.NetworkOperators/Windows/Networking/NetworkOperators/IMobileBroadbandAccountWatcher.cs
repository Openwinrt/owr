namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x6bf3335e, 0x23b5, 0x449f, 0x92, 0x8d, 0x5e, 13, 0x3e, 4, 0x47, 0x1d), ExclusiveTo(typeof(MobileBroadbandAccountWatcher))]
    internal interface IMobileBroadbandAccountWatcher
    {
        event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountEventArgs> AccountAdded;

        event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountEventArgs> AccountRemoved;

        event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountUpdatedEventArgs> AccountUpdated;

        event TypedEventHandler<MobileBroadbandAccountWatcher, object> EnumerationCompleted;

        event TypedEventHandler<MobileBroadbandAccountWatcher, object> Stopped;

        void Start();
        void Stop();

        MobileBroadbandAccountWatcherStatus Status { get; }
    }
}

