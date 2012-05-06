namespace Windows.Networking.NetworkOperators
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(MobileBroadbandAccount)), Guid(0x36c24ccd, 0xcee2, 0x43e0, 0xa6, 3, 0xee, 0x86, 0xa3, 0x6d, 0x65, 0x70), Version(0x6020000)]
    internal interface IMobileBroadbandAccount
    {
        MobileBroadbandDeviceInformation CurrentDeviceInformation { get; }

        MobileBroadbandNetwork CurrentNetwork { get; }

        string NetworkAccountId { get; }

        Guid ServiceProviderGuid { get; }

        string ServiceProviderName { get; }
    }
}

