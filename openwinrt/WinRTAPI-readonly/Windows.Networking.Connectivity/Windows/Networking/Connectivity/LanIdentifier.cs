namespace Windows.Networking.Connectivity
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class LanIdentifier : ILanIdentifier
    {
        public LanIdentifierData InfrastructureId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Guid NetworkAdapterId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanIdentifierData PortId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanIdentifierData Windows.Networking.Connectivity.ILanIdentifier.InfrastructureId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Guid Windows.Networking.Connectivity.ILanIdentifier.NetworkAdapterId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanIdentifierData Windows.Networking.Connectivity.ILanIdentifier.PortId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

