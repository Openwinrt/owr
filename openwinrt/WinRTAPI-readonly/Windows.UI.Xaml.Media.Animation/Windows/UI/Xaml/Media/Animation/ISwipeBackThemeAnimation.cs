namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xa38a4214, 0xbca, 0x4d2d, 0x95, 0xf7, 0xce, 0xba, 0x57, 0xfb, 0xaf, 0x60), ExclusiveTo(typeof(SwipeBackThemeAnimation))]
    internal interface ISwipeBackThemeAnimation
    {
        double FromHorizontalOffset { get; [param: In] set; }

        double FromVerticalOffset { get; [param: In] set; }

        string TargetName { get; [param: In] set; }
    }
}

