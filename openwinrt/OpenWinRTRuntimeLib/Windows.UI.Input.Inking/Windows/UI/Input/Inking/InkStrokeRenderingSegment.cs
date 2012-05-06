namespace Windows.UI.Input.Inking
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class InkStrokeRenderingSegment : IInkStrokeRenderingSegment
    {
        public Point BezierControlPoint1 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point BezierControlPoint2 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Pressure { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float TiltX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float TiltY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Twist { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Input.Inking.IInkStrokeRenderingSegment.BezierControlPoint1 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Input.Inking.IInkStrokeRenderingSegment.BezierControlPoint2 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Input.Inking.IInkStrokeRenderingSegment.Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.UI.Input.Inking.IInkStrokeRenderingSegment.Pressure { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.UI.Input.Inking.IInkStrokeRenderingSegment.TiltX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.UI.Input.Inking.IInkStrokeRenderingSegment.TiltY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.UI.Input.Inking.IInkStrokeRenderingSegment.Twist { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

