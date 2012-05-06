namespace Windows.UI.Input.Inking
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class InkRecognitionResult : IInkRecognitionResult
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<IInkStroke> GetStrokes();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<string> GetTextCandidates();

        public Rect BoundingRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Rect Windows.UI.Input.Inking.IInkRecognitionResult.BoundingRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

