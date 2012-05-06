namespace Windows.Devices.Enumeration
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class EnclosureLocation : IEnclosureLocation
    {
        public bool InDock { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool InLid { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Enumeration.Panel Panel { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Devices.Enumeration.IEnclosureLocation.InDock { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Devices.Enumeration.IEnclosureLocation.InLid { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Enumeration.Panel Windows.Devices.Enumeration.IEnclosureLocation.Panel { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

