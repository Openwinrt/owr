namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class StreamSocketListenerConnectionReceivedEventArgs : IStreamSocketListenerConnectionReceivedEventArgs
    {
        public StreamSocket Socket { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StreamSocket Windows.Networking.Sockets.IStreamSocketListenerConnectionReceivedEventArgs.Socket { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

