namespace Windows.Devices.Enumeration.Pnp
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Devices.Enumeration;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(PnpObjectWatcher)), Windows.Foundation.Metadata.Guid(0x83c95ca8, 0x4772, 0x4a7a, 0xac, 0xa8, 0xe4, 140, 0x42, 0xa8, 0x9c, 0x44)]
    internal interface IPnpObjectWatcher
    {
        event TypedEventHandler<PnpObjectWatcher, PnpObject> Added;

        event TypedEventHandler<PnpObjectWatcher, object> EnumerationCompleted;

        event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Removed;

        event TypedEventHandler<PnpObjectWatcher, object> Stopped;

        event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Updated;

        void Start();
        void Stop();

        DeviceWatcherStatus Status { get; }
    }
}

