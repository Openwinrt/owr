namespace Windows.Devices.Enumeration
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xaba0fb95, 0x4398, 0x489d, 0x8e, 0x44, 230, 0x13, 9, 0x27, 1, 0x1f), ExclusiveTo(typeof(DeviceInformation))]
    internal interface IDeviceInformation
    {
        IAsyncOperation<DeviceThumbnail> GetGlyphThumbnailAsync();
        IAsyncOperation<DeviceThumbnail> GetThumbnailAsync();
        void Update([In] DeviceInformationUpdate updateInfo);

        Windows.Devices.Enumeration.EnclosureLocation EnclosureLocation { get; }

        string Id { get; }

        bool IsDefault { get; }

        bool IsEnabled { get; }

        string Name { get; }

        IMapView<string, object> Properties { [return: HasVariant] get; }
    }
}

