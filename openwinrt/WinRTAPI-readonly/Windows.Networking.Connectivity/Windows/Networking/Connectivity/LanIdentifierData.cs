namespace Windows.Networking.Connectivity
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class LanIdentifierData : ILanIdentifierData
    {
        public uint Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<byte> Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Networking.Connectivity.ILanIdentifierData.Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<byte> Windows.Networking.Connectivity.ILanIdentifierData.Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

