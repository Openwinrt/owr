namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [DualApiPartition(version=0x6020000), Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Threading(ThreadingModel.MTA)]
    public sealed class StreamWebSocket : IStreamWebSocket, IWebSocket, IClosable
    {
        public event TypedEventHandler<IWebSocket, WebSocketClosedEventArgs> Closed;

        public event TypedEventHandler<IWebSocket, WebSocketClosedEventArgs> Windows.Networking.Sockets.IWebSocket.Closed;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public StreamWebSocket();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Close();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CloseWithStatus")]
        public void Close([In] ushort code, [In] string reason);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction ConnectAsync([In] Uri uri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetRequestHeader([In] string headerName, [In] string headerValue);

        public StreamWebSocketControl Control { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StreamWebSocketInformation Information { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IInputStream InputStream { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IOutputStream OutputStream { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StreamWebSocketControl Windows.Networking.Sockets.IStreamWebSocket.Control { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StreamWebSocketInformation Windows.Networking.Sockets.IStreamWebSocket.Information { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IInputStream Windows.Networking.Sockets.IStreamWebSocket.InputStream { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IOutputStream Windows.Networking.Sockets.IWebSocket.OutputStream { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

