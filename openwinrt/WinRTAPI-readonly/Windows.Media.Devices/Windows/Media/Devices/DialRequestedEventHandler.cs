namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5abbffdb, 0xc21f, 0x4bc4, 0x89, 0x1b, 0x25, 0x7e, 40, 0xc1, 0xb1, 0xa4)]
    public delegate void DialRequestedEventHandler([In] CallControl sender, [In] DialRequestedEventArgs e);
}

