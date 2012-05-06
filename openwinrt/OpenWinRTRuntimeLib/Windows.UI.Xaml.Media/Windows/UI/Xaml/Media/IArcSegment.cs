namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x7940c5f, 0x63fb, 0x4469, 0x91, 190, 0xf1, 9, 0x7c, 0x16, 0x80, 0x52), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(ArcSegment))]
    internal interface IArcSegment
    {
        bool IsLargeArc { get; [param: In] set; }

        Windows.Foundation.Point Point { get; [param: In] set; }

        double RotationAngle { get; [param: In] set; }

        Windows.Foundation.Size Size { get; [param: In] set; }

        Windows.UI.Xaml.Media.SweepDirection SweepDirection { get; [param: In] set; }
    }
}

