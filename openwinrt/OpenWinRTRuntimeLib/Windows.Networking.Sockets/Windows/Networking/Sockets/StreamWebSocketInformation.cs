namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.Networking;

    [DualApiPartition(version=0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class StreamWebSocketInformation : IWebSocketInformation
    {
        public Windows.Networking.Sockets.BandwidthStatistics BandwidthStatistics { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HostName LocalHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Protocol { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Sockets.BandwidthStatistics Windows.Networking.Sockets.IWebSocketInformation.BandwidthStatistics { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HostName Windows.Networking.Sockets.IWebSocketInformation.LocalHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.Sockets.IWebSocketInformation.Protocol { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

