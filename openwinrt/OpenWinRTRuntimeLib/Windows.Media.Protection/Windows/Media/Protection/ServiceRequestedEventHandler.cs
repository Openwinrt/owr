namespace Windows.Media.Protection
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xd2d690ba, 0xcac9, 0x48e1, 0x95, 0xc0, 0xd3, 0x84, 0x95, 0xa8, 0x40, 0x55)]
    public delegate void ServiceRequestedEventHandler([In] MediaProtectionManager sender, [In] ServiceRequestedEventArgs e);
}

