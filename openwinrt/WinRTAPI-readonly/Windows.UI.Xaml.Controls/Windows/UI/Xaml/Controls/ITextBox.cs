namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Input;

    [ExclusiveTo(typeof(TextBox)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe48f5a8b, 0x1dff, 0x4352, 0xa1, 0xf4, 0xe5, 0x16, 0x51, 0x4e, 200, 130)]
    internal interface ITextBox
    {
        event ContextMenuOpeningEventHandler ContextMenuOpening;

        event RoutedEventHandler SelectionChanged;

        event TextChangedEventHandler TextChanged;

        Rect GetRectFromCharacterIndex([In] int charIndex, [In] bool trailingEdge);
        void Select([In] int start, [In] int length);
        void SelectAll();

        bool AcceptsReturn { get; [param: In] set; }

        Windows.UI.Xaml.Input.InputScope InputScope { get; [param: In] set; }

        bool IsReadOnly { get; [param: In] set; }

        bool IsSpellCheckEnabled { get; [param: In] set; }

        bool IsTextPredictionEnabled { get; [param: In] set; }

        int MaxLength { get; [param: In] set; }

        string SelectedText { get; [param: In] set; }

        int SelectionLength { get; [param: In] set; }

        int SelectionStart { get; [param: In] set; }

        string Text { get; [param: In] set; }

        Windows.UI.Xaml.TextAlignment TextAlignment { get; [param: In] set; }

        Windows.UI.Xaml.TextWrapping TextWrapping { get; [param: In] set; }
    }
}

