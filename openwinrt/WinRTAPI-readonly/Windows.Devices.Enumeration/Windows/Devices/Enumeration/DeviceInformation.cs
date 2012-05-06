namespace Windows.Devices.Enumeration
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000), Static(typeof(IDeviceInformationStatics), 0x6020000), Threading(ThreadingModel.Both)]
    public sealed class DeviceInformation : IDeviceInformation
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateFromIdAsync"), DefaultOverload]
        public static IAsyncOperation<DeviceInformation> CreateFromIdAsync([In] string id);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateFromIdAsyncAdditionalProperties"), DefaultOverload]
        public static IAsyncOperation<DeviceInformation> CreateFromIdAsync([In] string id, [In] IIterable<string> additionalProperties);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateWatcher"), DefaultOverload]
        public static DeviceWatcher CreateWatcher();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateWatcherAqsFilter")]
        public static DeviceWatcher CreateWatcher([In] string aqsFilter);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateWatcherDeviceClass"), DefaultOverload]
        public static DeviceWatcher CreateWatcher([In] DeviceClass deviceClass);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateWatcherAqsFilterAndAdditionalProperties"), DefaultOverload]
        public static DeviceWatcher CreateWatcher([In] string aqsFilter, [In] IIterable<string> additionalProperties);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("FindAllAsync"), DefaultOverload]
        public static IAsyncOperation<DeviceInformationCollection> FindAllAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("FindAllAsyncAqsFilter")]
        public static IAsyncOperation<DeviceInformationCollection> FindAllAsync([In] string aqsFilter);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("FindAllAsyncDeviceClass"), DefaultOverload]
        public static IAsyncOperation<DeviceInformationCollection> FindAllAsync([In] DeviceClass deviceClass);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("FindAllAsyncAqsFilterAndAdditionalProperties"), DefaultOverload]
        public static IAsyncOperation<DeviceInformationCollection> FindAllAsync([In] string aqsFilter, [In] IIterable<string> additionalProperties);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<DeviceThumbnail> GetGlyphThumbnailAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<DeviceThumbnail> GetThumbnailAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Update([In] DeviceInformationUpdate updateInfo);

        public Windows.Devices.Enumeration.EnclosureLocation EnclosureLocation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsDefault { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, object> Properties { [return: HasVariant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Enumeration.EnclosureLocation Windows.Devices.Enumeration.IDeviceInformation.EnclosureLocation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Devices.Enumeration.IDeviceInformation.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Devices.Enumeration.IDeviceInformation.IsDefault { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Devices.Enumeration.IDeviceInformation.IsEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Devices.Enumeration.IDeviceInformation.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, object> Windows.Devices.Enumeration.IDeviceInformation.Properties { [return: HasVariant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

