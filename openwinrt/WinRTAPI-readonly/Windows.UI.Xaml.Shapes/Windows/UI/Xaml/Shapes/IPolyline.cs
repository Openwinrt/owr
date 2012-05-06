namespace Windows.UI.Xaml.Shapes
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Media;

    [Windows.Foundation.Metadata.Guid(0x91dc62f8, 0x42b3, 0x47f3, 0x84, 0x76, 0xc5, 0x51, 0x24, 0xa7, 0xc4, 0xc6), ExclusiveTo(typeof(Polyline)), WebHostHidden, Version(0x6020000)]
    internal interface IPolyline
    {
        Windows.UI.Xaml.Media.FillRule FillRule { get; [param: In] set; }

        PointCollection Points { get; [param: In] set; }
    }
}

