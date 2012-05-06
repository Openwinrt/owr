namespace Windows.UI.Xaml.Shapes
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Media;

    [WebHostHidden, ExclusiveTo(typeof(Polygon)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe3755c19, 0x2e4d, 0x4bcc, 0x8d, 0x34, 0x86, 0x87, 0x19, 0x57, 250, 1)]
    internal interface IPolygon
    {
        Windows.UI.Xaml.Media.FillRule FillRule { get; [param: In] set; }

        PointCollection Points { get; [param: In] set; }
    }
}

