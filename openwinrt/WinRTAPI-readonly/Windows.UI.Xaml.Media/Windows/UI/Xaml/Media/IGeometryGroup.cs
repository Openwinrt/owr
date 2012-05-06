namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(GeometryGroup)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x55225a61, 0x8677, 0x4c8c, 0x8e, 70, 0xee, 0x3d, 0xc3, 0x55, 0x11, 0x4b)]
    internal interface IGeometryGroup
    {
        GeometryCollection Children { get; [param: In] set; }

        Windows.UI.Xaml.Media.FillRule FillRule { get; [param: In] set; }
    }
}

