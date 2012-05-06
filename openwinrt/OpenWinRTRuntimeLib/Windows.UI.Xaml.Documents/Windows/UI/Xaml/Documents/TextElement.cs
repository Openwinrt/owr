namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Text;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;

    [Threading(ThreadingModel.Both), Static(typeof(ITextElementStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(ITextElementFactory), CompositionType.Protected, 0x6020000), Version(0x6020000), WebHostHidden]
    public class TextElement : DependencyObject, ITextElement, ITextElementOverrides
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public object FindName([In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnDisconnectVisualChildren();

        public int CharacterSpacing { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty CharacterSpacingProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer ContentEnd { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer ContentStart { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer ElementEnd { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer ElementStart { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

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

        public string Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty LanguageProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Documents.ITextElement.CharacterSpacing { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public TextPointer Windows.UI.Xaml.Documents.ITextElement.ContentEnd { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer Windows.UI.Xaml.Documents.ITextElement.ContentStart { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer Windows.UI.Xaml.Documents.ITextElement.ElementEnd { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer Windows.UI.Xaml.Documents.ITextElement.ElementStart { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.FontFamily Windows.UI.Xaml.Documents.ITextElement.FontFamily { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Documents.ITextElement.FontSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Text.FontStretch Windows.UI.Xaml.Documents.ITextElement.FontStretch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Text.FontStyle Windows.UI.Xaml.Documents.ITextElement.FontStyle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Text.FontWeight Windows.UI.Xaml.Documents.ITextElement.FontWeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Brush Windows.UI.Xaml.Documents.ITextElement.Foreground { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.Documents.ITextElement.Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.Documents.ITextElement.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

