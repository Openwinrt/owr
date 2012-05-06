namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Networking;

    [Windows.Foundation.Metadata.Guid(0xff513437, 0xdf9f, 0x4df0, 0xbf, 130, 14, 0xc5, 0xd7, 0xb3, 90, 0xae), ExclusiveTo(typeof(StreamSocketListener)), Version(0x6020000)]
    internal interface IStreamSocketListener : IClosable
    {
        event TypedEventHandler<StreamSocketListener, StreamSocketListenerConnectionReceivedEventArgs> ConnectionReceived;

        IAsyncAction BindEndpointAsync([In] HostName localHostName, [In] string localServiceName);
        IAsyncAction BindServiceNameAsync([In] string localServiceName);

        StreamSocketListenerControl Control { get; }

        StreamSocketListenerInformation Information { get; }
    }
}

