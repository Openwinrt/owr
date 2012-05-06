namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(CompositeTransform)), WebHostHidden, Guid(0x2f190c08, 0x8266, 0x496f, 150, 0x53, 0xa1, 0x8b, 0xd4, 0xf8, 0x36, 170), Version(0x6020000)]
    internal interface ICompositeTransformStatics
    {
        DependencyProperty CenterXProperty { get; }

        DependencyProperty CenterYProperty { get; }

        DependencyProperty RotationProperty { get; }

        DependencyProperty ScaleXProperty { get; }

        DependencyProperty ScaleYProperty { get; }

        DependencyProperty SkewXProperty { get; }

        DependencyProperty SkewYProperty { get; }

        DependencyProperty TranslateXProperty { get; }

        DependencyProperty TranslateYProperty { get; }
    }
}

