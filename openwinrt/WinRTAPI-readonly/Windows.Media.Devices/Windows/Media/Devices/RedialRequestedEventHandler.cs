namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xbaf257d1, 0x4ebd, 0x4b84, 0x9f, 0x47, 110, 0xc4, 0x3d, 0x75, 0xd8, 0xb1), Version(0x6020000)]
    public delegate void RedialRequestedEventHandler([In] CallControl sender, [In] RedialRequestedEventArgs e);
}

