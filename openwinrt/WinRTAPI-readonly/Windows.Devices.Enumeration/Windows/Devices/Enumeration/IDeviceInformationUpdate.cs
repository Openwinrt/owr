namespace Windows.Devices.Enumeration
{
    using System;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DeviceInformationUpdate)), Version(0x6020000), Guid(0x8f315305, 0xd972, 0x44b7, 0xa3, 0x7e, 0x9e, 130, 0x2c, 120, 0x21, 0x3b)]
    internal interface IDeviceInformationUpdate
    {
        string Id { get; }

        IMapView<string, object> Properties { [return: HasVariant] get; }
    }
}

