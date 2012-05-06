namespace Windows.UI.Xaml.Shapes
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(Rectangle)), Windows.Foundation.Metadata.Guid(0x855bc230, 0x8a11, 0x4e18, 0xa1, 0x36, 0x4b, 0xc2, 0x1c, 120, 0x27, 0xb0)]
    internal interface IRectangle
    {
        double RadiusX { get; [param: In] set; }

        double RadiusY { get; [param: In] set; }
    }
}

