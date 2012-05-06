namespace Windows.Devices.Enumeration.Pnp
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum PnpObjectType
    {
        Unknown,
        DeviceInterface,
        DeviceContainer,
        Device,
        DeviceInterfaceClass
    }
}

