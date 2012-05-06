namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(MessageWebSocket)), Windows.Foundation.Metadata.Guid(0x33727d08, 0x34d5, 0x4746, 0xad, 0x7b, 0x8d, 0xde, 0x5b, 0xc2, 0xef, 0x88)]
    internal interface IMessageWebSocket : IWebSocket, IClosable
    {
        event TypedEventHandler<MessageWebSocket, MessageWebSocketMessageReceivedEventArgs> MessageReceived;

        MessageWebSocketControl Control { get; }

        MessageWebSocketInformation Information { get; }
    }
}

