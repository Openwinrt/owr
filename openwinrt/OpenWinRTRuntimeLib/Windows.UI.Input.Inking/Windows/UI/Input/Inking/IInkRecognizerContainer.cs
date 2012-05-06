namespace Windows.UI.Input.Inking
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa74d9a31, 0x8047, 0x4698, 0xa9, 0x12, 0xf8, 0x2a, 80, 0x85, 1, 0x2f)]
    public interface IInkRecognizerContainer
    {
        IVectorView<IInkRecognizer> GetRecognizers();
        IAsyncOperation<IVectorView<IInkRecognitionResult>> RecognizeAsync([In] IInkStrokeContainer strokeCollection, [In] InkRecognitionTarget recognitionTarget);
        void SetDefaultRecognizer([In] IInkRecognizer recognizer);
    }
}

