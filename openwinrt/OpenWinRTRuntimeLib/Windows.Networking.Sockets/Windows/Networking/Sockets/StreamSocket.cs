namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Networking;
    using Windows.Storage.Streams;

    [Version(0x6020000), Activatable(0x6020000), Threading(ThreadingModel.MTA), MarshalingBehavior(MarshalingType.FreeThreaded), DualApiPartition(version=0x6020000)]
    public sealed class StreamSocket : IStreamSocket, IClosable
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public StreamSocket();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Close();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ConnectWithEndpointPairAsync")]
        public IAsyncAction ConnectAsync([In] EndpointPair endpointPair);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ConnectWithEndpointPairAndProtectionLevelAsync")]
        public IAsyncAction ConnectAsync([In] EndpointPair endpointPair, [In] SocketProtectionLevel protectionLevel);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("ConnectAsync")]
        public IAsyncAction ConnectAsync([In] HostName remoteHostName, [In] string remoteServiceName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ConnectWithProtectionLevelAsync")]
        public IAsyncAction ConnectAsync([In] HostName remoteHostName, [In] string remoteServiceName, [In] SocketProtectionLevel protectionLevel);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction UpgradeToSslAsync([In] SocketProtectionLevel protectionLevel, [In] HostName validationHostName);

        public StreamSocketControl Control { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StreamSocketInformation Information { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IInputStream InputStream { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IOutputStream OutputStream { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StreamSocketControl Windows.Networking.Sockets.IStreamSocket.Control { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StreamSocketInformation Windows.Networking.Sockets.IStreamSocket.Information { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IInputStream Windows.Networking.Sockets.IStreamSocket.InputStream { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IOutputStream Windows.Networking.Sockets.IStreamSocket.OutputStream { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

