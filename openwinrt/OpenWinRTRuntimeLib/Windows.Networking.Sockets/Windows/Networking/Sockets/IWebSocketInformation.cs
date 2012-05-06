namespace Windows.Networking.Sockets
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.Networking;

    [Guid(0x5e01e316, 0xc92a, 0x47a5, 0xb2, 0x5f, 7, 0x84, 0x76, 0x39, 0xd1, 0x81), Version(0x6020000)]
    public interface IWebSocketInformation
    {
        Windows.Networking.Sockets.BandwidthStatistics BandwidthStatistics { get; }

        HostName LocalHostName { get; }

        string Protocol { get; }
    }
}

