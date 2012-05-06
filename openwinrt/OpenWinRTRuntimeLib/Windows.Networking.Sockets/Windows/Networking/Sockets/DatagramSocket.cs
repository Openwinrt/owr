namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Networking;
    using Windows.Storage.Streams;

    [Static(typeof(IDatagramSocketStatics), 0x6020000), DualApiPartition(version=0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Activatable(0x6020000), Threading(ThreadingModel.MTA)]
    public sealed class DatagramSocket : IDatagramSocket, IClosable
    {
        public event TypedEventHandler<DatagramSocket, DatagramSocketMessageReceivedEventArgs> MessageReceived;

        public event TypedEventHandler<DatagramSocket, DatagramSocketMessageReceivedEventArgs> Windows.Networking.Sockets.IDatagramSocket.MessageReceived;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DatagramSocket();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction BindEndpointAsync([In] HostName localHostName, [In] string localServiceName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction BindServiceNameAsync([In] string localServiceName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Close();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ConnectWithEndpointPairAsync")]
        public IAsyncAction ConnectAsync([In] EndpointPair endpointPair);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ConnectAsync")]
        public IAsyncAction ConnectAsync([In] HostName remoteHostName, [In] string remoteServiceName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetEndpointPairsAsync")]
        public static IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync([In] HostName remoteHostName, [In] string remoteServiceName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetEndpointPairsWithSortOptionsAsync")]
        public static IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync([In] HostName remoteHostName, [In] string remoteServiceName, [In] HostNameSortOptions sortOptions);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetOutputStreamWithEndpointPairAsync")]
        public IAsyncOperation<IOutputStream> GetOutputStreamAsync([In] EndpointPair endpointPair);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetOutputStreamAsync")]
        public IAsyncOperation<IOutputStream> GetOutputStreamAsync([In] HostName remoteHostName, [In] string remoteServiceName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void JoinMulticastGroup([In] HostName host);

        public DatagramSocketControl Control { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DatagramSocketInformation Information { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IOutputStream OutputStream { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DatagramSocketControl Windows.Networking.Sockets.IDatagramSocket.Control { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DatagramSocketInformation Windows.Networking.Sockets.IDatagramSocket.Information { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IOutputStream Windows.Networking.Sockets.IDatagramSocket.OutputStream { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

