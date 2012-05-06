namespace Windows.Devices.Enumeration
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xc9eab97d, 0x8f6b, 0x4f96, 0xa9, 0xf4, 0xab, 200, 20, 0xe2, 0x22, 0x71), Version(0x6020000), ExclusiveTo(typeof(DeviceWatcher))]
    internal interface IDeviceWatcher
    {
        event TypedEventHandler<DeviceWatcher, DeviceInformation> Added;

        event TypedEventHandler<DeviceWatcher, object> EnumerationCompleted;

        event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Removed;

        event TypedEventHandler<DeviceWatcher, object> Stopped;

        event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Updated;

        void Start();
        void Stop();

        DeviceWatcherStatus Status { get; }
    }
}

