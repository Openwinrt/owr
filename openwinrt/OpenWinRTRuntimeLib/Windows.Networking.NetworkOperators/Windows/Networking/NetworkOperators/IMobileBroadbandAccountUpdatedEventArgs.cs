namespace Windows.Networking.NetworkOperators
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x7bc31d88, 0xa6bd, 0x49e1, 0x80, 0xab, 0x6b, 0x91, 0x35, 0x4a, 0x57, 0xd4), Version(0x6020000), ExclusiveTo(typeof(MobileBroadbandAccountUpdatedEventArgs))]
    internal interface IMobileBroadbandAccountUpdatedEventArgs
    {
        bool HasDeviceInformationChanged { get; }

        bool HasNetworkChanged { get; }

        string NetworkAccountId { get; }
    }
}

