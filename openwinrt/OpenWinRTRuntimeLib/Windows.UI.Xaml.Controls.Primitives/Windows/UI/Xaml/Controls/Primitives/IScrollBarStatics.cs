namespace Windows.UI.Xaml.Controls.Primitives
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Guid(0x45eaf38d, 0xb814, 0x48cf, 0x97, 0xf2, 0x53, 0x9e, 0xb1, 0x6d, 0xfd, 0x4d), ExclusiveTo(typeof(ScrollBar)), WebHostHidden]
    internal interface IScrollBarStatics
    {
        DependencyProperty IndicatorModeProperty { get; }

        DependencyProperty OrientationProperty { get; }

        DependencyProperty ViewportSizeProperty { get; }
    }
}

