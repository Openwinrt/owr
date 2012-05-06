namespace Windows.Devices.Enumeration.Pnp
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x95c66258, 0x733b, 0x4a8f, 0x93, 0xa3, 0xdb, 7, 0x8a, 200, 0x70, 0xc1), ExclusiveTo(typeof(PnpObject)), Version(0x6020000)]
    internal interface IPnpObject
    {
        void Update([In] PnpObjectUpdate updateInfo);

        string Id { get; }

        IMapView<string, object> Properties { [return: HasVariant] get; }

        PnpObjectType Type { get; }
    }
}

