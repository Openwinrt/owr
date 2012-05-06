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

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xae2d9271, 0x3b4a, 0x45fc, 0x84, 0x68, 0xf7, 0x94, 0x95, 0x48, 0xf4, 0xd5), WebHostHidden, ExclusiveTo(typeof(TextBlock))]
    internal interface ITextBlock
    {
        event ContextMenuOpeningEventHandler ContextMenuOpening;

        event RoutedEventHandler SelectionChanged;

        bool Focus([In] FocusState value);
        void Select([In] TextPointer start, [In] TextPointer end);
        void SelectAll();

        double BaselineOffset { get; }

        int CharacterSpacing { get; [param: In] set; }

        TextPointer ContentEnd { get; }

        TextPointer ContentStart { get; }

        Windows.UI.Xaml.Media.FontFamily FontFamily { get; [param: In] set; }

        double FontSize { get; [param: In] set; }

        Windows.UI.Text.FontStretch FontStretch { get; [param: In] set; }

        Windows.UI.Text.FontStyle FontStyle { get; [param: In] set; }

        Windows.UI.Text.FontWeight FontWeight { get; [param: In] set; }

        Brush Foreground { get; [param: In] set; }

        InlineCollection Inlines { get; }

        bool IsTextSelectionEnabled { get; [param: In] set; }

        double LineHeight { get; [param: In] set; }

        Windows.UI.Xaml.LineStackingStrategy LineStackingStrategy { get; [param: In] set; }

        Thickness Padding { get; [param: In] set; }

        string SelectedText { get; }

        TextPointer SelectionEnd { get; }

        TextPointer SelectionStart { get; }

        string Text { get; [param: In] set; }

        Windows.UI.Xaml.TextAlignment TextAlignment { get; [param: In] set; }

        Windows.UI.Xaml.TextTrimming TextTrimming { get; [param: In] set; }

        Windows.UI.Xaml.TextWrapping TextWrapping { get; [param: In] set; }
    }
}

