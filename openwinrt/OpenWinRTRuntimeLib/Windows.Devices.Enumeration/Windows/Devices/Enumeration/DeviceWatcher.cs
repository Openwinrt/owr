namespace Windows.Devices.Enumeration
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class DeviceWatcher : IDeviceWatcher
    {
        public event TypedEventHandler<DeviceWatcher, DeviceInformation> Added;

        public event TypedEventHandler<DeviceWatcher, object> EnumerationCompleted;

        public event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Removed;

        public event TypedEventHandler<DeviceWatcher, object> Stopped;

        public event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Updated;

        public event TypedEventHandler<DeviceWatcher, DeviceInformation> Windows.Devices.Enumeration.IDeviceWatcher.Added;

        public event TypedEventHandler<DeviceWatcher, object> Windows.Devices.Enumeration.IDeviceWatcher.EnumerationCompleted;

        public event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Windows.Devices.Enumeration.IDeviceWatcher.Removed;

        public event TypedEventHandler<DeviceWatcher, object> Windows.Devices.Enumeration.IDeviceWatcher.Stopped;

        public event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Windows.Devices.Enumeration.IDeviceWatcher.Updated;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Start();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Stop();

        public DeviceWatcherStatus Status { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DeviceWatcherStatus Windows.Devices.Enumeration.IDeviceWatcher.Status { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

