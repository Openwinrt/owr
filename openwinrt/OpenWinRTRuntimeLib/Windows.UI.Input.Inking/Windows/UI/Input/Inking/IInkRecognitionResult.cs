namespace Windows.UI.Input.Inking
{
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x36461a94, 0x5068, 0x40ef, 0x8a, 5, 0x2c, 0x2f, 0xb6, 9, 8, 0xa2)]
    public interface IInkRecognitionResult
    {
        IVectorView<IInkStroke> GetStrokes();
        IVectorView<string> GetTextCandidates();

        Rect BoundingRect { get; }
    }
}

