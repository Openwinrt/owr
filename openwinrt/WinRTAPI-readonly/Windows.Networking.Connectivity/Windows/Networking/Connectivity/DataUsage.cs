namespace Windows.Networking.Connectivity
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), DualApiPartition(version=0x6020000)]
    public sealed class DataUsage : IDataUsage
    {
        public ulong BytesReceived { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong BytesSent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong Windows.Networking.Connectivity.IDataUsage.BytesReceived { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong Windows.Networking.Connectivity.IDataUsage.BytesSent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

