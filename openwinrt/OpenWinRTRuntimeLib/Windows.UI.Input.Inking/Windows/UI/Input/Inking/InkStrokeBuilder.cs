namespace Windows.UI.Input.Inking
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Input;

    [Threading(ThreadingModel.Both), DualApiPartition(version=0x6020000), Version(0x6020000), Activatable(0x6020000)]
    public sealed class InkStrokeBuilder : IInkStrokeBuilder
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public InkStrokeBuilder();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PointerPoint AppendToStroke([In] PointerPoint pointerPoint);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void BeginStroke([In] PointerPoint pointerPoint);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public InkStroke CreateStroke([In] IIterable<Point> points);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public InkStroke EndStroke([In] PointerPoint pointerPoint);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetDefaultDrawingAttributes([In] InkDrawingAttributes drawingAttributes);
    }
}

