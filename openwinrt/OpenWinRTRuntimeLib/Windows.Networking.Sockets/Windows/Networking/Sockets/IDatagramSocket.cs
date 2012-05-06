namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Networking;
    using Windows.Storage.Streams;

    [Windows.Foundation.Metadata.Guid(0x7fe25bbb, 0xc3bc, 0x4677, 0x84, 70, 0xca, 40, 0xa4, 0x65, 0xa3, 0xaf), Version(0x6020000), ExclusiveTo(typeof(DatagramSocket))]
    internal interface IDatagramSocket : IClosable
    {
        event TypedEventHandler<DatagramSocket, DatagramSocketMessageReceivedEventArgs> MessageReceived;

        IAsyncAction BindEndpointAsync([In] HostName localHostName, [In] string localServiceName);
        IAsyncAction BindServiceNameAsync([In] string localServiceName);
        [Overload("ConnectWithEndpointPairAsync")]
        IAsyncAction ConnectAsync([In] EndpointPair endpointPair);
        [Overload("ConnectAsync")]
        IAsyncAction ConnectAsync([In] HostName remoteHostName, [In] string remoteServiceName);
        [Overload("GetOutputStreamWithEndpointPairAsync")]
        IAsyncOperation<IOutputStream> GetOutputStreamAsync([In] EndpointPair endpointPair);
        [Overload("GetOutputStreamAsync")]
        IAsyncOperation<IOutputStream> GetOutputStreamAsync([In] HostName remoteHostName, [In] string remoteServiceName);
        void JoinMulticastGroup([In] HostName host);

        DatagramSocketControl Control { get; }

        DatagramSocketInformation Information { get; }

        IOutputStream OutputStream { get; }
    }
}

