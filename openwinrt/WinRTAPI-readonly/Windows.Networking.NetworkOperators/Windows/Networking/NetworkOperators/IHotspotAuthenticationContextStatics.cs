namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(HotspotAuthenticationContext)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe756c791, 0x1002, 0x4de5, 0x83, 0xc7, 0xde, 0x61, 0xd8, 0x88, 0x31, 0xd0)]
    internal interface IHotspotAuthenticationContextStatics
    {
        bool TryGetAuthenticationContext([In] string evenToken, out HotspotAuthenticationContext context);
    }
}

