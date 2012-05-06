namespace Windows.UI.Xaml.Printing
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Graphics.Printing;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), Composable(typeof(IPrintDocumentFactory), CompositionType.Public, 0x6020000), Static(typeof(IPrintDocumentStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both)]
    public class PrintDocument : DependencyObject, IPrintDocument
    {
        public event AddPagesEventHandler AddPages;

        public event GetPreviewPageEventHandler GetPreviewPage;

        public event PaginateEventHandler Paginate;

        public event AddPagesEventHandler Windows.UI.Xaml.Printing.IPrintDocument.AddPages;

        public event GetPreviewPageEventHandler Windows.UI.Xaml.Printing.IPrintDocument.GetPreviewPage;

        public event PaginateEventHandler Windows.UI.Xaml.Printing.IPrintDocument.Paginate;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PrintDocument();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddPage([In] UIElement pageVisual);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddPagesComplete();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void InvalidatePreview();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetPreviewPage([In] int pageNumber, [In] UIElement pageVisual);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetPreviewPageCount([In] int count, [In] PreviewPageCountType type);

        public IPrintDocumentSource DocumentSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty DocumentSourceProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IPrintDocumentSource Windows.UI.Xaml.Printing.IPrintDocument.DocumentSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

