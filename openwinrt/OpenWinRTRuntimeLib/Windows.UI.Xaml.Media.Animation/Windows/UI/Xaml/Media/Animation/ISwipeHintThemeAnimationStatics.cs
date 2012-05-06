namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0x23d61a57, 0x9115, 0x4d63, 0xb0, 0x4a, 0xb8, 0x9f, 0x1c, 0x74, 0x4d, 0xc0), Version(0x6020000), ExclusiveTo(typeof(SwipeHintThemeAnimation)), WebHostHidden]
    internal interface ISwipeHintThemeAnimationStatics
    {
        DependencyProperty TargetNameProperty { get; }

        DependencyProperty ToHorizontalOffsetProperty { get; }

        DependencyProperty ToVerticalOffsetProperty { get; }
    }
}

