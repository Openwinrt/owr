namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), DualApiPartition(version=0x6020000), Threading(ThreadingModel.MTA), Version(0x6020000)]
    public sealed class MessageWebSocket : IMessageWebSocket, IWebSocket, IClosable
    {
        public event TypedEventHandler<IWebSocket, WebSocketClosedEventArgs> Closed;

        public event TypedEventHandler<MessageWebSocket, MessageWebSocketMessageReceivedEventArgs> MessageReceived;

        public event TypedEventHandler<MessageWebSocket, MessageWebSocketMessageReceivedEventArgs> Windows.Networking.Sockets.IMessageWebSocket.MessageReceived;

        public event TypedEventHandler<IWebSocket, WebSocketClosedEventArgs> Windows.Networking.Sockets.IWebSocket.Closed;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public MessageWebSocket();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Close();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CloseWithStatus")]
        public void Close([In] ushort code, [In] string reason);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction ConnectAsync([In] Uri uri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetRequestHeader([In] string headerName, [In] string headerValue);

        public MessageWebSocketControl Control { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MessageWebSocketInformation Information { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IOutputStream OutputStream { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MessageWebSocketControl Windows.Networking.Sockets.IMessageWebSocket.Control { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MessageWebSocketInformation Windows.Networking.Sockets.IMessageWebSocket.Information { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IOutputStream Windows.Networking.Sockets.IWebSocket.OutputStream { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

