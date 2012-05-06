namespace Windows.Networking.Proximity
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xefaa0b4a, 0xf6e2, 0x4d7d, 0x85, 0x6c, 120, 0xfc, 0x8e, 0xfc, 2, 30), Version(0x6020000)]
    public delegate void MessageTransmittedHandler([In] ProximityDevice sender, [In] long messageId);
}

