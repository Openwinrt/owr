namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xe637a454, 0xc527, 0x422c, 0x89, 0x26, 0xc9, 0xaf, 0x83, 0xb5, 0x59, 160), Version(0x6020000)]
    public delegate void KeypadPressedEventHandler([In] CallControl sender, [In] KeypadPressedEventArgs e);
}

