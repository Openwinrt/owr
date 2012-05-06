namespace Windows.Networking.Connectivity
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Networking;

    [Version(0x6020000), Static(typeof(INetworkInformationStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), DualApiPartition(version=0x6020000)]
    public static class NetworkInformation
    {
        public static  event NetworkStatusChangedEventHandler NetworkStatusChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IVectorView<ConnectionProfile> GetConnectionProfiles();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IVectorView<HostName> GetHostNames();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ConnectionProfile GetInternetConnectionProfile();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IVectorView<LanIdentifier> GetLanIdentifiers();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<ProxyConfiguration> GetProxyConfigurationAsync([In] Uri uri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IVectorView<EndpointPair> GetSortedEndpointPairs([In] IIterable<EndpointPair> destinationList, [In] HostNameSortOptions sortOptions);
    }
}

