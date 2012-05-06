namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Guid(0x961661f9, 0x8bb4, 0x4e6c, 0xb9, 0x23, 0xb5, 0xd7, 0x87, 0xe0, 0xf1, 0xa9), ExclusiveTo(typeof(GradientBrush)), Version(0x6020000)]
    internal interface IGradientBrushStatics
    {
        DependencyProperty ColorInterpolationModeProperty { get; }

        DependencyProperty GradientStopsProperty { get; }

        DependencyProperty MappingModeProperty { get; }

        DependencyProperty SpreadMethodProperty { get; }
    }
}

