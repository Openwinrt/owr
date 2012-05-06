namespace Windows.UI
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x8504dbea, 0xfb6a, 0x4144, 0xa6, 0xc2, 0x33, 0x49, 0x9c, 0x92, 0x84, 0xf5), ExclusiveTo(typeof(ColorHelper)), Version(0x6020000)]
    internal interface IColorHelperStatics
    {
        Color FromArgb([In] byte a, [In] byte r, [In] byte g, [In] byte b);
    }
}

