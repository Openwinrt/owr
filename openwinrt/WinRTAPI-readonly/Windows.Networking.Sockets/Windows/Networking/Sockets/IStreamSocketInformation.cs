namespace Windows.Networking.Sockets
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.Networking;

    [Version(0x6020000), Guid(0x3b80ae30, 0x5e68, 0x4205, 0x88, 240, 220, 0x85, 210, 0xe2, 0x5d, 0xed), ExclusiveTo(typeof(StreamSocketInformation))]
    internal interface IStreamSocketInformation
    {
        Windows.Networking.Sockets.BandwidthStatistics BandwidthStatistics { get; }

        HostName LocalHostName { get; }

        string LocalServiceName { get; }

        HostName RemoteHostName { get; }

        string RemoteServiceName { get; }

        Windows.Networking.Sockets.RoundTripTimeStatistics RoundTripTimeStatistics { get; }

        SocketProtectionLevel SslStrength { get; }
    }
}

