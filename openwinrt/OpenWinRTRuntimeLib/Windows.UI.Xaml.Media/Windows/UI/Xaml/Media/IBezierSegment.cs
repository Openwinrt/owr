namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xaf4bb9ee, 0x8984, 0x49b7, 0x81, 0xdf, 0x3f, 0x35, 0x99, 0x4b, 0x95, 0xeb), ExclusiveTo(typeof(BezierSegment))]
    internal interface IBezierSegment
    {
        Point Point1 { get; [param: In] set; }

        Point Point2 { get; [param: In] set; }

        Point Point3 { get; [param: In] set; }
    }
}

