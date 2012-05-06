namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xfcc88d01, 0x7f82, 0x4dae, 0x80, 0x26, 0x7b, 0x7e, 8, 0x68, 120, 0xb3), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(PointKeyFrame))]
    internal interface IPointKeyFrame
    {
        Windows.UI.Xaml.Media.Animation.KeyTime KeyTime { get; [param: In] set; }

        Point Value { get; [param: In] set; }
    }
}

