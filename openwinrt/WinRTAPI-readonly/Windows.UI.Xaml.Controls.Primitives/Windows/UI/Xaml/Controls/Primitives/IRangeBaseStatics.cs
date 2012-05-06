namespace Windows.UI.Xaml.Controls.Primitives
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(RangeBase)), WebHostHidden, Guid(0x67ef17e1, 0xfe37, 0x474f, 0x9e, 0x97, 0x3b, 0x5e, 11, 0x30, 0xf2, 0xe0), Version(0x6020000)]
    internal interface IRangeBaseStatics
    {
        DependencyProperty LargeChangeProperty { get; }

        DependencyProperty MaximumProperty { get; }

        DependencyProperty MinimumProperty { get; }

        DependencyProperty SmallChangeProperty { get; }

        DependencyProperty ValueProperty { get; }
    }
}

