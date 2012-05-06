namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, ExclusiveTo(typeof(Control)), Version(0x6020000), Guid(0x473b305b, 0x877d, 0x4c35, 0x8f, 0xca, 70, 160, 0x5f, 150, 0x60, 0x7a)]
    internal interface IControlStatics
    {
        DependencyProperty BackgroundProperty { get; }

        DependencyProperty BorderBrushProperty { get; }

        DependencyProperty BorderThicknessProperty { get; }

        DependencyProperty CharacterSpacingProperty { get; }

        DependencyProperty DefaultStyleKeyProperty { get; }

        DependencyProperty FocusStateProperty { get; }

        DependencyProperty FontFamilyProperty { get; }

        DependencyProperty FontSizeProperty { get; }

        DependencyProperty FontStretchProperty { get; }

        DependencyProperty FontStyleProperty { get; }

        DependencyProperty FontWeightProperty { get; }

        DependencyProperty ForegroundProperty { get; }

        DependencyProperty HorizontalContentAlignmentProperty { get; }

        DependencyProperty IsEnabledProperty { get; }

        DependencyProperty IsTabStopProperty { get; }

        DependencyProperty PaddingProperty { get; }

        DependencyProperty TabIndexProperty { get; }

        DependencyProperty TabNavigationProperty { get; }

        DependencyProperty TemplateProperty { get; }

        DependencyProperty VerticalContentAlignmentProperty { get; }
    }
}

