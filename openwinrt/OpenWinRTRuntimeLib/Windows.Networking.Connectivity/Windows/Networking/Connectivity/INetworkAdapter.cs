namespace Windows.Networking.Connectivity
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0x3b542e03, 0x5388, 0x496c, 0xa8, 0xa3, 0xaf, 0xfd, 0x39, 0xae, 0xc2, 230), ExclusiveTo(typeof(NetworkAdapter)), Version(0x6020000)]
    internal interface INetworkAdapter
    {
        IAsyncOperation<ConnectionProfile> GetConnectedProfileAsync();

        uint IanaInterfaceType { get; }

        ulong InboundMaxBitsPerSecond { get; }

        Guid NetworkAdapterId { get; }

        Windows.Networking.Connectivity.NetworkItem NetworkItem { get; }

        ulong OutboundMaxBitsPerSecond { get; }
    }
}

