namespace Windows.Networking.Connectivity
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(NetworkItem)), Guid(0x1bc4d39, 0xf5e0, 0x4567, 0xa2, 140, 0x42, 8, 12, 0x83, 0x1b, 0x2b)]
    internal interface INetworkItem
    {
        NetworkTypes GetNetworkTypes();

        Guid NetworkId { get; }
    }
}

