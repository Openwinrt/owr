namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Networking;

    [Windows.Foundation.Metadata.Guid(0xe9c62aee, 0x1494, 0x4a21, 0xbb, 0x7e, 0x85, 0x89, 0xfc, 0x75, 0x1d, 0x9d), ExclusiveTo(typeof(DatagramSocket)), Version(0x6020000)]
    internal interface IDatagramSocketStatics
    {
        [Overload("GetEndpointPairsAsync")]
        IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync([In] HostName remoteHostName, [In] string remoteServiceName);
        [Overload("GetEndpointPairsWithSortOptionsAsync")]
        IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync([In] HostName remoteHostName, [In] string remoteServiceName, [In] HostNameSortOptions sortOptions);
    }
}

