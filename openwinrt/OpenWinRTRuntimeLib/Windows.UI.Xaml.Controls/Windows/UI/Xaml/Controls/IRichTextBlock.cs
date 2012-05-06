namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Text;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Documents;
    using Windows.UI.Xaml.Media;

    [ExclusiveTo(typeof(RichTextBlock)), Windows.Foundation.Metadata.Guid(0xe5fff9e2, 0xb968, 0x49e7, 0x97, 0xd4, 140, 0xca, 0x2a, 0xc3, 0xae, 0x7c), Version(0x6020000), WebHostHidden]
    internal interface IRichTextBlock
    {
        event ContextMenuOpeningEventHandler ContextMenuOpening;

        event RoutedEventHandler SelectionChanged;

        bool Focus([In] FocusState value);
        TextPointer GetPositionFromPoint([In] Point point);
        void Select([In] TextPointer start, [In] TextPointer end);
        void SelectAll();

        double BaselineOffset { get; }

        BlockCollection Blocks { get; }

        int CharacterSpacing { get; [param: In] set; }

        TextPointer ContentEnd { get; }

        TextPointer ContentStart { get; }

        Windows.UI.Xaml.Media.FontFamily FontFamily { get; [param: In] set; }

        double FontSize { get; [param: In] set; }

        Windows.UI.Text.FontStretch FontStretch { get; [param: In] set; }

        Windows.UI.Text.FontStyle FontStyle { get; [param: In] set; }

        Windows.UI.Text.FontWeight FontWeight { get; [param: In] set; }

        Brush Foreground { get; [param: In] set; }

        bool HasOverflowContent { get; }

        bool IsTextSelectionEnabled { get; [param: In] set; }

        double LineHeight { get; [param: In] set; }

        Windows.UI.Xaml.LineStackingStrategy LineStackingStrategy { get; [param: In] set; }

        RichTextBlockOverflow OverflowContentTarget { get; [param: In] set; }

        Thickness Padding { get; [param: In] set; }

        string SelectedText { get; }

        TextPointer SelectionEnd { get; }

        TextPointer SelectionStart { get; }

        Windows.UI.Xaml.TextAlignment TextAlignment { get; [param: In] set; }

        Windows.UI.Xaml.TextTrimming TextTrimming { get; [param: In] set; }

        Windows.UI.Xaml.TextWrapping TextWrapping { get; [param: In] set; }
    }
}

