namespace Windows.Networking.Connectivity
{
    using System;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(LanIdentifierData)), Version(0x6020000), Guid(0xa74e83c3, 0xd639, 0x45be, 0xa3, 0x6a, 0xc4, 0xe4, 0xae, 0xaf, 0x6d, 0x9b)]
    internal interface ILanIdentifierData
    {
        uint Type { get; }

        IVectorView<byte> Value { get; }
    }
}

