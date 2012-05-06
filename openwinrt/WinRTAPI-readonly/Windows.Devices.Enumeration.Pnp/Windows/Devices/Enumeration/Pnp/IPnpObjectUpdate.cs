namespace Windows.Devices.Enumeration.Pnp
{
    using System;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(PnpObjectUpdate)), Guid(0x6f59e812, 30, 0x4844, 0xbc, 0xc6, 0x43, 40, 0x86, 0x85, 0x6a, 0x17)]
    internal interface IPnpObjectUpdate
    {
        string Id { get; }

        IMapView<string, object> Properties { [return: HasVariant] get; }

        PnpObjectType Type { get; }
    }
}

