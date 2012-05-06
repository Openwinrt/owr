namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(RichTextBlock)), WebHostHidden, Version(0x6020000), Guid(0x492d883c, 0xadea, 0x433c, 190, 0x1c, 0x20, 0x8a, 0x16, 0x42, 0x62, 190)]
    internal interface IRichTextBlockStatics
    {
        DependencyProperty CharacterSpacingProperty { get; }

        DependencyProperty FontFamilyProperty { get; }

        DependencyProperty FontSizeProperty { get; }

        DependencyProperty FontStretchProperty { get; }

        DependencyProperty FontStyleProperty { get; }

        DependencyProperty FontWeightProperty { get; }

        DependencyProperty ForegroundProperty { get; }

        DependencyProperty HasOverflowContentProperty { get; }

        DependencyProperty IsTextSelectionEnabledProperty { get; }

        DependencyProperty LineHeightProperty { get; }

        DependencyProperty LineStackingStrategyProperty { get; }

        DependencyProperty OverflowContentTargetProperty { get; }

        DependencyProperty PaddingProperty { get; }

        DependencyProperty SelectedTextProperty { get; }

        DependencyProperty TextAlignmentProperty { get; }

        DependencyProperty TextTrimmingProperty { get; }

        DependencyProperty TextWrappingProperty { get; }
    }
}

