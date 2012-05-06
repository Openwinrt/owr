namespace Windows.UI.Input.Inking
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Input;

    [Windows.Foundation.Metadata.Guid(0x4744737d, 0x671b, 0x4163, 0x9c, 0x95, 0x4e, 0x8d, 0x7a, 3, 0x5f, 0xe1), ExclusiveTo(typeof(InkManager)), Version(0x6020000)]
    internal interface IInkManager : IInkStrokeContainer, IInkRecognizerContainer
    {
        void ProcessPointerDown([In] PointerPoint pointerPoint);
        Rect ProcessPointerUp([In] PointerPoint pointerPoint);
        [return: Variant]
        object ProcessPointerUpdate([In] PointerPoint pointerPoint);
        [DefaultOverload, Overload("RecognizeAsync2")]
        IAsyncOperation<IVectorView<IInkRecognitionResult>> RecognizeAsync([In] InkRecognitionTarget recognitionTarget);
        void SetDefaultDrawingAttributes([In] InkDrawingAttributes drawingAttributes);

        InkManipulationMode Mode { get; [param: In] set; }
    }
}

