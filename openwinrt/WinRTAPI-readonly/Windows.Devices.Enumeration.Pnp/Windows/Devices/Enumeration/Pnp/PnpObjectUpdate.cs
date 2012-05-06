namespace Windows.Devices.Enumeration.Pnp
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class PnpObjectUpdate : IPnpObjectUpdate
    {
        public string Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, object> Properties { [return: HasVariant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PnpObjectType Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Devices.Enumeration.Pnp.IPnpObjectUpdate.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, object> Windows.Devices.Enumeration.Pnp.IPnpObjectUpdate.Properties { [return: HasVariant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PnpObjectType Windows.Devices.Enumeration.Pnp.IPnpObjectUpdate.Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

