namespace Windows.Networking.Sockets
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(WebSocketClosedEventArgs)), Guid(0xceb78d07, 0xd0a8, 0x4703, 160, 0x91, 200, 0xc2, 0xc0, 0x91, 0x5b, 0xc3)]
    internal interface IWebSocketClosedEventArgs
    {
        ushort Code { get; }

        string Reason { get; }
    }
}

