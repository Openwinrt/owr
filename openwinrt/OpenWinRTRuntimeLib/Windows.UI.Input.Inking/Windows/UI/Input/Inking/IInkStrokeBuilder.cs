namespace Windows.UI.Input.Inking
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Input;

    [Windows.Foundation.Metadata.Guid(0x82bbd1dc, 0x1c63, 0x41dc, 0x9e, 7, 0x4b, 0x4a, 0x70, 0xce, 0xd8, 1), ExclusiveTo(typeof(InkStrokeBuilder)), Version(0x6020000)]
    internal interface IInkStrokeBuilder
    {
        PointerPoint AppendToStroke([In] PointerPoint pointerPoint);
        void BeginStroke([In] PointerPoint pointerPoint);
        InkStroke CreateStroke([In] IIterable<Point> points);
        InkStroke EndStroke([In] PointerPoint pointerPoint);
        void SetDefaultDrawingAttributes([In] InkDrawingAttributes drawingAttributes);
    }
}

