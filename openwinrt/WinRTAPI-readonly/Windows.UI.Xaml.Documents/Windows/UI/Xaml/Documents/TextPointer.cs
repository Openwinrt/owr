namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both)]
    public sealed class TextPointer : ITextPointer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Rect GetCharacterRect([In] Windows.UI.Xaml.Documents.LogicalDirection direction);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public TextPointer GetPositionAtOffset([In] int offset, [In] Windows.UI.Xaml.Documents.LogicalDirection direction);

        public Windows.UI.Xaml.Documents.LogicalDirection LogicalDirection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Offset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DependencyObject Parent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public FrameworkElement VisualParent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Documents.LogicalDirection Windows.UI.Xaml.Documents.ITextPointer.LogicalDirection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Documents.ITextPointer.Offset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DependencyObject Windows.UI.Xaml.Documents.ITextPointer.Parent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public FrameworkElement Windows.UI.Xaml.Documents.ITextPointer.VisualParent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

