namespace Windows.Networking.Proximity
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PeerInformation)), Version(0x6020000), Guid(0x20024f08, 0x9fff, 0x45f4, 0xb6, 0xe9, 0x40, 0x8b, 0x2e, 190, 0xf3, 0x73)]
    internal interface IPeerInformation
    {
        string DisplayName { get; }
    }
}

