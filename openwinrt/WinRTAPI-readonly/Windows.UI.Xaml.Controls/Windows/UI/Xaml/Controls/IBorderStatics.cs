namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0xb81d1639, 0xe911, 0x4fd7, 0xa4, 0xc4, 0xb9, 0xc7, 240, 8, 0xb7, 0xfc), ExclusiveTo(typeof(Border)), WebHostHidden, Version(0x6020000)]
    internal interface IBorderStatics
    {
        DependencyProperty BackgroundProperty { get; }

        DependencyProperty BorderBrushProperty { get; }

        DependencyProperty BorderThicknessProperty { get; }

        DependencyProperty ChildTransitionsProperty { get; }

        DependencyProperty CornerRadiusProperty { get; }

        DependencyProperty PaddingProperty { get; }
    }
}

