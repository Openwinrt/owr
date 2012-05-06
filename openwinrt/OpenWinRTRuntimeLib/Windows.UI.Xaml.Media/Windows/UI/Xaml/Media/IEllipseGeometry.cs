namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xd4f61bba, 0x4ea2, 0x40d6, 170, 0x6c, 0x8d, 0x38, 170, 0x87, 0x65, 0x1f), Version(0x6020000), ExclusiveTo(typeof(EllipseGeometry)), WebHostHidden]
    internal interface IEllipseGeometry
    {
        Point Center { get; [param: In] set; }

        double RadiusX { get; [param: In] set; }

        double RadiusY { get; [param: In] set; }
    }
}

