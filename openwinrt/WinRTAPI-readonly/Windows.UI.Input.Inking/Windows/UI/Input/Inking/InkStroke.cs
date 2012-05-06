namespace Windows.UI.Input.Inking
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class InkStroke : IInkStroke
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public InkStroke Clone();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<IInkStrokeRenderingSegment> GetRenderingSegments();

        public Rect BoundingRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public InkDrawingAttributes DrawingAttributes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Recognized { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Selected { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Rect Windows.UI.Input.Inking.IInkStroke.BoundingRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public InkDrawingAttributes Windows.UI.Input.Inking.IInkStroke.DrawingAttributes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Input.Inking.IInkStroke.Recognized { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Input.Inking.IInkStroke.Selected { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

