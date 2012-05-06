namespace Windows.Devices.Enumeration.Pnp
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Devices.Enumeration;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class PnpObjectWatcher : IPnpObjectWatcher
    {
        public event TypedEventHandler<PnpObjectWatcher, PnpObject> Added;

        public event TypedEventHandler<PnpObjectWatcher, object> EnumerationCompleted;

        public event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Removed;

        public event TypedEventHandler<PnpObjectWatcher, object> Stopped;

        public event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Updated;

        public event TypedEventHandler<PnpObjectWatcher, PnpObject> Windows.Devices.Enumeration.Pnp.IPnpObjectWatcher.Added;

        public event TypedEventHandler<PnpObjectWatcher, object> Windows.Devices.Enumeration.Pnp.IPnpObjectWatcher.EnumerationCompleted;

        public event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Windows.Devices.Enumeration.Pnp.IPnpObjectWatcher.Removed;

        public event TypedEventHandler<PnpObjectWatcher, object> Windows.Devices.Enumeration.Pnp.IPnpObjectWatcher.Stopped;

        public event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Windows.Devices.Enumeration.Pnp.IPnpObjectWatcher.Updated;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Start();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Stop();

        public DeviceWatcherStatus Status { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DeviceWatcherStatus Windows.Devices.Enumeration.Pnp.IPnpObjectWatcher.Status { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

