namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xfa123889, 0xacd, 0x417b, 0xb6, 0x2d, 0x5c, 0xa1, 0xbf, 0x4d, 0xfc, 14), WebHostHidden, ExclusiveTo(typeof(Geometry)), Version(0x6020000)]
    internal interface IGeometry
    {
        Rect Bounds { get; }

        Windows.UI.Xaml.Media.Transform Transform { get; [param: In] set; }
    }
}

