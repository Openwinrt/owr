namespace Windows.Networking.Connectivity
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(LanIdentifier)), Guid(0x48aa53aa, 0x1108, 0x4546, 0xa6, 0xcb, 0x9a, 0x74, 0xda, 0x4b, 0x7b, 160)]
    internal interface ILanIdentifier
    {
        LanIdentifierData InfrastructureId { get; }

        Guid NetworkAdapterId { get; }

        LanIdentifierData PortId { get; }
    }
}

