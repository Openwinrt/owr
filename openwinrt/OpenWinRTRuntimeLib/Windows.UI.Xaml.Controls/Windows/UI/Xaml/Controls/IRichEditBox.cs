namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Text;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Input;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x90a57a40, 0x80b6, 0x4fce, 0xb1, 0xec, 0xe3, 0xc6, 0x16, 40, 0x4b, 0x6a), ExclusiveTo(typeof(RichEditBox))]
    internal interface IRichEditBox
    {
        event ContextMenuOpeningEventHandler ContextMenuOpening;

        event RoutedEventHandler SelectionChanged;

        event RoutedEventHandler TextChanged;

        bool AcceptsReturn { get; [param: In] set; }

        ITextDocument Document { get; }

        Windows.UI.Xaml.Input.InputScope InputScope { get; [param: In] set; }

        bool IsReadOnly { get; [param: In] set; }

        bool IsSpellCheckEnabled { get; [param: In] set; }

        bool IsTextPredictionEnabled { get; [param: In] set; }

        Windows.UI.Xaml.TextAlignment TextAlignment { get; [param: In] set; }

        Windows.UI.Xaml.TextWrapping TextWrapping { get; [param: In] set; }
    }
}

