namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class WebSocketClosedEventArgs : IWebSocketClosedEventArgs
    {
        public ushort Code { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Reason { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ushort Windows.Networking.Sockets.IWebSocketClosedEventArgs.Code { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.Sockets.IWebSocketClosedEventArgs.Reason { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

