namespace Windows.UI.Input.Inking
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x15144d60, 0xcce3, 0x4fcf, 0x9d, 0x52, 0x11, 0x51, 0x8a, 0xb6, 0xaf, 0xd4), Version(0x6020000)]
    public interface IInkStroke
    {
        InkStroke Clone();
        IVectorView<IInkStrokeRenderingSegment> GetRenderingSegments();

        Rect BoundingRect { get; }

        InkDrawingAttributes DrawingAttributes { get; [param: In] set; }

        bool Recognized { get; }

        bool Selected { get; [param: In] set; }
    }
}

