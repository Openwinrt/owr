namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x30f04312, 0x7726, 0x4f88, 0xb8, 0xe2, 0x2f, 0xa5, 0x45, 0x18, 150, 0x3b), ExclusiveTo(typeof(PointAnimation)), Version(0x6020000)]
    internal interface IPointAnimation
    {
        IReference<Point> By { get; [param: In] set; }

        EasingFunctionBase EasingFunction { get; [param: In] set; }

        bool EnableDependentAnimation { get; [param: In] set; }

        IReference<Point> From { get; [param: In] set; }

        IReference<Point> To { get; [param: In] set; }
    }
}

