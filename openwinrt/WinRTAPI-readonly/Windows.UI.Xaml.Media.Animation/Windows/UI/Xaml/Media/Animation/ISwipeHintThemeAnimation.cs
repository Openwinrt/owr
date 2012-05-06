namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(SwipeHintThemeAnimation)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xcdd067c0, 0x580e, 0x4e40, 190, 0x98, 0xf2, 2, 0xd3, 0xd8, 0x43, 0x65)]
    internal interface ISwipeHintThemeAnimation
    {
        string TargetName { get; [param: In] set; }

        double ToHorizontalOffset { get; [param: In] set; }

        double ToVerticalOffset { get; [param: In] set; }
    }
}

