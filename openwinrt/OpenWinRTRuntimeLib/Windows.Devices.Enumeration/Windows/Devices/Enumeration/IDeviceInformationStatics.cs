namespace Windows.Devices.Enumeration
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xc17f100e, 0x3a46, 0x4a78, 0x80, 0x13, 0x76, 0x9d, 0xc9, 0xb9, 0x73, 0x90), ExclusiveTo(typeof(DeviceInformation)), Version(0x6020000)]
    internal interface IDeviceInformationStatics
    {
        [DefaultOverload, Overload("CreateFromIdAsync")]
        IAsyncOperation<DeviceInformation> CreateFromIdAsync([In] string id);
        [DefaultOverload, Overload("CreateFromIdAsyncAdditionalProperties")]
        IAsyncOperation<DeviceInformation> CreateFromIdAsync([In] string id, [In] IIterable<string> additionalProperties);
        [DefaultOverload, Overload("CreateWatcher")]
        DeviceWatcher CreateWatcher();
        [Overload("CreateWatcherAqsFilter")]
        DeviceWatcher CreateWatcher([In] string aqsFilter);
        [Overload("CreateWatcherDeviceClass"), DefaultOverload]
        DeviceWatcher CreateWatcher([In] DeviceClass deviceClass);
        [Overload("CreateWatcherAqsFilterAndAdditionalProperties"), DefaultOverload]
        DeviceWatcher CreateWatcher([In] string aqsFilter, [In] IIterable<string> additionalProperties);
        [Overload("FindAllAsync"), DefaultOverload]
        IAsyncOperation<DeviceInformationCollection> FindAllAsync();
        [Overload("FindAllAsyncAqsFilter")]
        IAsyncOperation<DeviceInformationCollection> FindAllAsync([In] string aqsFilter);
        [Overload("FindAllAsyncDeviceClass"), DefaultOverload]
        IAsyncOperation<DeviceInformationCollection> FindAllAsync([In] DeviceClass deviceClass);
        [DefaultOverload, Overload("FindAllAsyncAqsFilterAndAdditionalProperties")]
        IAsyncOperation<DeviceInformationCollection> FindAllAsync([In] string aqsFilter, [In] IIterable<string> additionalProperties);
    }
}

