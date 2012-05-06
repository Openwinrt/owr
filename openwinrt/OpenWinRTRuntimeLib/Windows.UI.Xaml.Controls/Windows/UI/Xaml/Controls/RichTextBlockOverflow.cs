namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Documents;

    [Activatable(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, Static(typeof(IRichTextBlockOverflowStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class RichTextBlockOverflow : FrameworkElement, IRichTextBlockOverflow
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public RichTextBlockOverflow();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool Focus([In] FocusState value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public TextPointer GetPositionFromPoint([In] Point point);

        public double BaselineOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer ContentEnd { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public RichTextBlock ContentSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer ContentStart { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool HasOverflowContent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty HasOverflowContentProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public RichTextBlockOverflow OverflowContentTarget { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty OverflowContentTargetProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Thickness Padding { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty PaddingProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IRichTextBlockOverflow.BaselineOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer Windows.UI.Xaml.Controls.IRichTextBlockOverflow.ContentEnd { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public RichTextBlock Windows.UI.Xaml.Controls.IRichTextBlockOverflow.ContentSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TextPointer Windows.UI.Xaml.Controls.IRichTextBlockOverflow.ContentStart { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IRichTextBlockOverflow.HasOverflowContent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public RichTextBlockOverflow Windows.UI.Xaml.Controls.IRichTextBlockOverflow.OverflowContentTarget { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Thickness Windows.UI.Xaml.Controls.IRichTextBlockOverflow.Padding { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

