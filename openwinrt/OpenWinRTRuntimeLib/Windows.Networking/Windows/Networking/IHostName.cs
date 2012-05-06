namespace Windows.Networking
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Networking.Connectivity;

    [Version(0x6020000), ExclusiveTo(typeof(HostName)), Windows.Foundation.Metadata.Guid(0xbf8ecaad, 0xed96, 0x49a7, 0x90, 0x84, 0xd4, 0x16, 0xca, 0xe8, 0x8d, 0xcb)]
    internal interface IHostName
    {
        bool IsEqual([In] HostName hostName);

        string CanonicalName { get; }

        string DisplayName { get; }

        Windows.Networking.Connectivity.NetworkAdapter NetworkAdapter { get; }

        string RawName { get; }
    }
}

