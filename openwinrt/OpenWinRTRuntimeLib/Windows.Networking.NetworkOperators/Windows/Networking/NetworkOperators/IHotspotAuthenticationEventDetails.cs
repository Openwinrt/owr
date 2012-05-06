namespace Windows.Networking.NetworkOperators
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xe756c791, 0x1001, 0x4de5, 0x83, 0xc7, 0xde, 0x61, 0xd8, 0x88, 0x31, 0xd0), Version(0x6020000), ExclusiveTo(typeof(HotspotAuthenticationEventDetails))]
    internal interface IHotspotAuthenticationEventDetails
    {
        string EventToken { get; }
    }
}

