namespace Windows.Networking.Connectivity
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Networking;

    [Windows.Foundation.Metadata.Guid(0x5074f851, 0x950d, 0x4165, 0x9c, 0x15, 0x36, 0x56, 0x19, 0x48, 30, 0xea), Version(0x6020000), ExclusiveTo(typeof(NetworkInformation))]
    internal interface INetworkInformationStatics
    {
        event NetworkStatusChangedEventHandler NetworkStatusChanged;

        IVectorView<ConnectionProfile> GetConnectionProfiles();
        IVectorView<HostName> GetHostNames();
        ConnectionProfile GetInternetConnectionProfile();
        IVectorView<LanIdentifier> GetLanIdentifiers();
        IAsyncOperation<ProxyConfiguration> GetProxyConfigurationAsync([In] Uri uri);
        IVectorView<EndpointPair> GetSortedEndpointPairs([In] IIterable<EndpointPair> destinationList, [In] HostNameSortOptions sortOptions);
    }
}

