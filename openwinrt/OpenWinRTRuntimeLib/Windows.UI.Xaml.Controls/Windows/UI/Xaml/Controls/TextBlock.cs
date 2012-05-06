namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Text;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Documents;
    using Windows.UI.Xaml.Markup;
    using Windows.UI.Xaml.Media;

    [Version(0x6020000), ContentProperty(Name="Inlines"), Threading(ThreadingModel.Both), Static(typeof(ITextBlockStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Activatable(0x6020000)]
    public sealed class TextBlock : FrameworkElement, ITextBlock
    {
        public event ContextMenuOpeningEventHandler ContextMenuOpening;

        public event RoutedEventHandler SelectionChanged;

        public event ContextMenuOpeningEventHandler Windows.UI.Xaml.Controls.ITextBlock.ContextMenuOpening;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.ITextBlock.SelectionChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public TextBlock();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool Focus([In] FocusState value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Select([In] TextPointer start, [In] TextPointer end);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SelectAll();

        public double BaselineOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int CharacterSpacing { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty CharacterSpacingProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer ContentEnd { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer ContentStart { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.FontFamily FontFamily { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FontFamilyProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double FontSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FontSizeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Text.FontStretch FontStretch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FontStretchProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Text.FontStyle FontStyle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FontStyleProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Text.FontWeight FontWeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FontWeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Brush Foreground { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ForegroundProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public InlineCollection Inlines { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsTextSelectionEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsTextSelectionEnabledProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double LineHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty LineHeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.LineStackingStrategy LineStackingStrategy { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty LineStackingStrategyProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Thickness Padding { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty PaddingProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string SelectedText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty SelectedTextProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer SelectionEnd { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer SelectionStart { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Text { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.TextAlignment TextAlignment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty TextAlignmentProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty TextProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.TextTrimming TextTrimming { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty TextTrimmingProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.TextWrapping TextWrapping { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty TextWrappingProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.ITextBlock.BaselineOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Controls.ITextBlock.CharacterSpacing { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public TextPointer Windows.UI.Xaml.Controls.ITextBlock.ContentEnd { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer Windows.UI.Xaml.Controls.ITextBlock.ContentStart { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.FontFamily Windows.UI.Xaml.Controls.ITextBlock.FontFamily { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.ITextBlock.FontSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Text.FontStretch Windows.UI.Xaml.Controls.ITextBlock.FontStretch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Text.FontStyle Windows.UI.Xaml.Controls.ITextBlock.FontStyle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Text.FontWeight Windows.UI.Xaml.Controls.ITextBlock.FontWeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Brush Windows.UI.Xaml.Controls.ITextBlock.Foreground { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public InlineCollection Windows.UI.Xaml.Controls.ITextBlock.Inlines { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.ITextBlock.IsTextSelectionEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.ITextBlock.LineHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.LineStackingStrategy Windows.UI.Xaml.Controls.ITextBlock.LineStackingStrategy { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Thickness Windows.UI.Xaml.Controls.ITextBlock.Padding { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.Controls.ITextBlock.SelectedText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer Windows.UI.Xaml.Controls.ITextBlock.SelectionEnd { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer Windows.UI.Xaml.Controls.ITextBlock.SelectionStart { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Xaml.Controls.ITextBlock.Text { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.TextAlignment Windows.UI.Xaml.Controls.ITextBlock.TextAlignment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.TextTrimming Windows.UI.Xaml.Controls.ITextBlock.TextTrimming { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.TextWrapping Windows.UI.Xaml.Controls.ITextBlock.TextWrapping { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

