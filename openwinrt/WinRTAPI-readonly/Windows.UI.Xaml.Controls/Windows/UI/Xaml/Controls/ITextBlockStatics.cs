namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0x193ec042, 0xa847, 0x4552, 180, 0xe8, 0xdb, 0x36, 0x65, 0x5b, 0x84, 10), Version(0x6020000), ExclusiveTo(typeof(TextBlock)), WebHostHidden]
    internal interface ITextBlockStatics
    {
        DependencyProperty CharacterSpacingProperty { get; }

        DependencyProperty FontFamilyProperty { get; }

        DependencyProperty FontSizeProperty { get; }

        DependencyProperty FontStretchProperty { get; }

        DependencyProperty FontStyleProperty { get; }

        DependencyProperty FontWeightProperty { get; }

        DependencyProperty ForegroundProperty { get; }

        DependencyProperty IsTextSelectionEnabledProperty { get; }

        DependencyProperty LineHeightProperty { get; }

        DependencyProperty LineStackingStrategyProperty { get; }

        DependencyProperty PaddingProperty { get; }

        DependencyProperty SelectedTextProperty { get; }

        DependencyProperty TextAlignmentProperty { get; }

        DependencyProperty TextProperty { get; }

        DependencyProperty TextTrimmingProperty { get; }

        DependencyProperty TextWrappingProperty { get; }
    }
}

