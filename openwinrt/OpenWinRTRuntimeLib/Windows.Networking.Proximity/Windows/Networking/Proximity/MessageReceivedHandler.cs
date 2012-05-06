namespace Windows.Networking.Proximity
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xefab0782, 0xf6e2, 0x4675, 160, 0x45, 0xd8, 0xe3, 0x20, 0xc2, 0x48, 8), Version(0x6020000)]
    public delegate void MessageReceivedHandler([In] ProximityDevice sender, [In] ProximityMessage message);
}

