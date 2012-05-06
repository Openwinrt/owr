namespace Windows.UI.Input.Inking
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Activatable(0x6020000), DualApiPartition(version=0x6020000), Threading(ThreadingModel.Both), Version(0x6020000)]
    public sealed class InkStrokeContainer : IInkStrokeContainer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public InkStrokeContainer();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddStroke([In] IInkStroke stroke);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool CanPasteFromClipboard();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void CopySelectedToClipboard();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Rect DeleteSelected();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<IInkRecognitionResult> GetRecognitionResults();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<IInkStroke> GetStrokes();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncActionWithProgress<ulong> LoadAsync([In] IInputStream inputStream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Rect MoveSelected([In] Point translation);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Rect PasteFromClipboard([In] Point position);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<uint, uint> SaveAsync([In] IOutputStream outputStream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Rect SelectWithLine([In] Point from, [In] Point to);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Rect SelectWithPolyLine([In] IIterable<Point> polyline);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void UpdateRecognitionResults([In] IVectorView<IInkRecognitionResult> recognitionResults);

        public Rect BoundingRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Rect Windows.UI.Input.Inking.IInkStrokeContainer.BoundingRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

