namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(Timeline)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xa902ed4e, 0xef10, 0x4d6f, 0x9a, 0x40, 0x93, 0xcb, 0x88, 0x95, 0xf4, 0xe5), Version(0x6020000)]
    internal interface ITimelineStatics
    {
        bool AllowDependentAnimations { get; [param: In] set; }

        DependencyProperty AutoReverseProperty { get; }

        DependencyProperty BeginTimeProperty { get; }

        DependencyProperty DurationProperty { get; }

        DependencyProperty FillBehaviorProperty { get; }

        DependencyProperty RepeatBehaviorProperty { get; }

        DependencyProperty SpeedRatioProperty { get; }
    }
}

