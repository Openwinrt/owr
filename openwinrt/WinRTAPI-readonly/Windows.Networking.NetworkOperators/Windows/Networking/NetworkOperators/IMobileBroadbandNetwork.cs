namespace Windows.Networking.NetworkOperators
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.Networking.Connectivity;

    [Version(0x6020000), Guid(0xcb63928c, 0x309, 0x4cb6, 0xa8, 0xc1, 0x6a, 90, 60, 0x8e, 0x1f, 0xf6), ExclusiveTo(typeof(MobileBroadbandNetwork))]
    internal interface IMobileBroadbandNetwork
    {
        string AccessPointName { get; }

        uint ActivationNetworkError { get; }

        Windows.Networking.Connectivity.NetworkAdapter NetworkAdapter { get; }

        Windows.Networking.NetworkOperators.NetworkRegistrationState NetworkRegistrationState { get; }

        uint PacketAttachNetworkError { get; }

        uint RegistrationNetworkError { get; }
    }
}

