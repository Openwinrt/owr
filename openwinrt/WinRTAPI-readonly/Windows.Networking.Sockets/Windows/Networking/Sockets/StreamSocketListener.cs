namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Networking;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Activatable(0x6020000), DualApiPartition(version=0x6020000), Threading(ThreadingModel.MTA)]
    public sealed class StreamSocketListener : IStreamSocketListener, IClosable
    {
        public event TypedEventHandler<StreamSocketListener, StreamSocketListenerConnectionReceivedEventArgs> ConnectionReceived;

        public event TypedEventHandler<StreamSocketListener, StreamSocketListenerConnectionReceivedEventArgs> Windows.Networking.Sockets.IStreamSocketListener.ConnectionReceived;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public StreamSocketListener();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction BindEndpointAsync([In] HostName localHostName, [In] string localServiceName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction BindServiceNameAsync([In] string localServiceName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Close();

        public StreamSocketListenerControl Control { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StreamSocketListenerInformation Information { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StreamSocketListenerControl Windows.Networking.Sockets.IStreamSocketListener.Control { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StreamSocketListenerInformation Windows.Networking.Sockets.IStreamSocketListener.Information { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

