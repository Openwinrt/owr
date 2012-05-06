namespace Windows.UI.Input.Inking
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Threading(ThreadingModel.Both), Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class InkRecognizerContainer : IInkRecognizerContainer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public InkRecognizerContainer();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<IInkRecognizer> GetRecognizers();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IVectorView<IInkRecognitionResult>> RecognizeAsync([In] IInkStrokeContainer strokeCollection, [In] InkRecognitionTarget recognitionTarget);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetDefaultRecognizer([In] IInkRecognizer recognizer);
    }
}

