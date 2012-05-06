namespace Windows.UI.Xaml.Printing
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Graphics.Printing;
    using Windows.UI.Xaml;

    [WebHostHidden, ExclusiveTo(typeof(PrintDocument)), Windows.Foundation.Metadata.Guid(0xe44327c3, 0xa999, 0x485b, 0xb1, 0xd8, 0x72, 220, 0x51, 120, 0x21, 230), Version(0x6020000)]
    internal interface IPrintDocument
    {
        event AddPagesEventHandler AddPages;

        event GetPreviewPageEventHandler GetPreviewPage;

        event PaginateEventHandler Paginate;

        void AddPage([In] UIElement pageVisual);
        void AddPagesComplete();
        void InvalidatePreview();
        void SetPreviewPage([In] int pageNumber, [In] UIElement pageVisual);
        void SetPreviewPageCount([In] int count, [In] PreviewPageCountType type);

        IPrintDocumentSource DocumentSource { get; }
    }
}

