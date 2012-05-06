namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.Networking;

    [MarshalingBehavior(MarshalingType.FreeThreaded), DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class StreamSocketInformation : IStreamSocketInformation
    {
        public Windows.Networking.Sockets.BandwidthStatistics BandwidthStatistics { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HostName LocalHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string LocalServiceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HostName RemoteHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string RemoteServiceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Sockets.RoundTripTimeStatistics RoundTripTimeStatistics { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SocketProtectionLevel SslStrength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Sockets.BandwidthStatistics Windows.Networking.Sockets.IStreamSocketInformation.BandwidthStatistics { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HostName Windows.Networking.Sockets.IStreamSocketInformation.LocalHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.Sockets.IStreamSocketInformation.LocalServiceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HostName Windows.Networking.Sockets.IStreamSocketInformation.RemoteHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.Sockets.IStreamSocketInformation.RemoteServiceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Sockets.RoundTripTimeStatistics Windows.Networking.Sockets.IStreamSocketInformation.RoundTripTimeStatistics { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SocketProtectionLevel Windows.Networking.Sockets.IStreamSocketInformation.SslStrength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

