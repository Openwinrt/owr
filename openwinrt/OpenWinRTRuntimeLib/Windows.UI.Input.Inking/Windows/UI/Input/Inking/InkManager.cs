namespace Windows.UI.Input.Inking
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;
    using Windows.UI.Input;

    [Version(0x6020000), DualApiPartition(version=0x6020000), Activatable(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class InkManager : IInkManager, IInkStrokeContainer, IInkRecognizerContainer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public InkManager();
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
        public IVectorView<IInkRecognizer> GetRecognizers();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<IInkStroke> GetStrokes();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncActionWithProgress<ulong> LoadAsync([In] IInputStream inputStream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Rect MoveSelected([In] Point translation);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Rect PasteFromClipboard([In] Point position);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ProcessPointerDown([In] PointerPoint pointerPoint);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Rect ProcessPointerUp([In] PointerPoint pointerPoint);
        [return: Variant]
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public object ProcessPointerUpdate([In] PointerPoint pointerPoint);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RecognizeAsync2"), DefaultOverload]
        public IAsyncOperation<IVectorView<IInkRecognitionResult>> RecognizeAsync([In] InkRecognitionTarget recognitionTarget);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IVectorView<IInkRecognitionResult>> RecognizeAsync([In] IInkStrokeContainer strokeCollection, [In] InkRecognitionTarget recognitionTarget);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<uint, uint> SaveAsync([In] IOutputStream outputStream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Rect SelectWithLine([In] Point from, [In] Point to);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Rect SelectWithPolyLine([In] IIterable<Point> polyline);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetDefaultDrawingAttributes([In] InkDrawingAttributes drawingAttributes);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetDefaultRecognizer([In] IInkRecognizer recognizer);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void UpdateRecognitionResults([In] IVectorView<IInkRecognitionResult> recognitionResults);

        public Rect BoundingRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public InkManipulationMode Mode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public InkManipulationMode Windows.UI.Input.Inking.IInkManager.Mode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Rect Windows.UI.Input.Inking.IInkStrokeContainer.BoundingRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

