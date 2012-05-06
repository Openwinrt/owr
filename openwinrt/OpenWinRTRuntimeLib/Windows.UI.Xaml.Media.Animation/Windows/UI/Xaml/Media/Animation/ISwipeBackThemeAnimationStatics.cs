namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), WebHostHidden, Guid(0x693f31bf, 0x4da6, 0x468a, 140, 0xe0, 0x99, 0x6c, 0x9a, 0xad, 0x42, 0xe0), ExclusiveTo(typeof(SwipeBackThemeAnimation))]
    internal interface ISwipeBackThemeAnimationStatics
    {
        DependencyProperty FromHorizontalOffsetProperty { get; }

        DependencyProperty FromVerticalOffsetProperty { get; }

        DependencyProperty TargetNameProperty { get; }
    }
}

