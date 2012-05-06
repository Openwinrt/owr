namespace Windows.Media.Protection
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x95da643c, 0x6db9, 0x424b, 0x86, 0xca, 9, 0x1a, 0xf4, 50, 8, 0x1c)]
    public delegate void ComponentLoadFailedEventHandler([In] MediaProtectionManager sender, [In] ComponentLoadFailedEventArgs e);
}

