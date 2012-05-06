namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(MessageWebSocketControl)), Windows.Foundation.Metadata.Guid(0x8118388a, 0xc629, 0x4f0a, 0x80, 0xfb, 0x81, 0xfc, 5, 0x53, 0x88, 0x62)]
    internal interface IMessageWebSocketControl : IWebSocketControl
    {
        uint MaxMessageSize { get; [param: In] set; }

        SocketMessageType MessageType { get; [param: In] set; }
    }
}

