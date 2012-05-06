namespace Windows.Networking.Connectivity
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class NetworkItem : INetworkItem
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public NetworkTypes GetNetworkTypes();

        public Guid NetworkId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Guid Windows.Networking.Connectivity.INetworkItem.NetworkId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

