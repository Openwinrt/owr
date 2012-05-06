namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(Brush)), WebHostHidden, Version(0x6020000), Guid(0xe70c3102, 0x225, 0x47f5, 0xb2, 0x2e, 4, 0x67, 0x61, 0x9f, 0x6a, 0x22)]
    internal interface IBrushStatics
    {
        DependencyProperty OpacityProperty { get; }

        DependencyProperty RelativeTransformProperty { get; }

        DependencyProperty TransformProperty { get; }
    }
}

