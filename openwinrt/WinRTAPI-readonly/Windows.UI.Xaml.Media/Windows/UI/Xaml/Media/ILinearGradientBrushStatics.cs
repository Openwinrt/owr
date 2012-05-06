namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(LinearGradientBrush)), WebHostHidden, Guid(0x7af6e504, 0x2dc3, 0x40e3, 190, 11, 0xb3, 20, 0xc1, 60, 0xb9, 0x91), Version(0x6020000)]
    internal interface ILinearGradientBrushStatics
    {
        DependencyProperty EndPointProperty { get; }

        DependencyProperty StartPointProperty { get; }
    }
}

