namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(QuadraticBezierSegment)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x2c509a5b, 0xbf18, 0x455a, 160, 120, 0x91, 0x4b, 0x52, 50, 0xd8, 0xaf)]
    internal interface IQuadraticBezierSegment
    {
        Point Point1 { get; [param: In] set; }

        Point Point2 { get; [param: In] set; }
    }
}

