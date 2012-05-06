namespace Windows.UI.Input.Inking
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Windows.Foundation.Metadata.Guid(0x22accbc6, 0xfaa9, 0x4f14, 0xb6, 140, 0xf6, 0xce, 230, 0x70, 0xae, 0x16), Version(0x6020000)]
    public interface IInkStrokeContainer
    {
        void AddStroke([In] IInkStroke stroke);
        bool CanPasteFromClipboard();
        void CopySelectedToClipboard();
        Rect DeleteSelected();
        IVectorView<IInkRecognitionResult> GetRecognitionResults();
        IVectorView<IInkStroke> GetStrokes();
        IAsyncActionWithProgress<ulong> LoadAsync([In] IInputStream inputStream);
        Rect MoveSelected([In] Point translation);
        Rect PasteFromClipboard([In] Point position);
        IAsyncOperationWithProgress<uint, uint> SaveAsync([In] IOutputStream outputStream);
        Rect SelectWithLine([In] Point from, [In] Point to);
        Rect SelectWithPolyLine([In] IIterable<Point> polyline);
        void UpdateRecognitionResults([In] IVectorView<IInkRecognitionResult> recognitionResults);

        Rect BoundingRect { get; }
    }
}

