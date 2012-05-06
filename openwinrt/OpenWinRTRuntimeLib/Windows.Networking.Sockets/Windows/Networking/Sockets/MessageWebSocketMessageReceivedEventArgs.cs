namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class MessageWebSocketMessageReceivedEventArgs : IMessageWebSocketMessageReceivedEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataReader GetDataReader();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IInputStream GetDataStream();

        public SocketMessageType MessageType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SocketMessageType Windows.Networking.Sockets.IMessageWebSocketMessageReceivedEventArgs.MessageType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

