namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x399658a2, 0x14fb, 0x4b8f, 0x83, 230, 110, 0x3d, 0xab, 0x12, 6, 0x9b), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(Brush))]
    internal interface IBrushFactory
    {
        Brush CreateInstance([In] object outer, out object inner);
    }
}

