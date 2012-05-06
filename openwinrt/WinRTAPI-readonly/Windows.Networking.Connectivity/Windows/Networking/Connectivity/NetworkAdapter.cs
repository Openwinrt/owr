namespace Windows.Networking.Connectivity
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class NetworkAdapter : INetworkAdapter
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<ConnectionProfile> GetConnectedProfileAsync();

        public uint IanaInterfaceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong InboundMaxBitsPerSecond { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Guid NetworkAdapterId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Connectivity.NetworkItem NetworkItem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong OutboundMaxBitsPerSecond { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Networking.Connectivity.INetworkAdapter.IanaInterfaceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong Windows.Networking.Connectivity.INetworkAdapter.InboundMaxBitsPerSecond { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Guid Windows.Networking.Connectivity.INetworkAdapter.NetworkAdapterId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Connectivity.NetworkItem Windows.Networking.Connectivity.INetworkAdapter.NetworkItem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong Windows.Networking.Connectivity.INetworkAdapter.OutboundMaxBitsPerSecond { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

