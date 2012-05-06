namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), Version(0x6020000), WebHostHidden, Threading(ThreadingModel.Both), Static(typeof(IQuadraticBezierSegmentStatics), 0x6020000)]
    public sealed class QuadraticBezierSegment : PathSegment, IQuadraticBezierSegment
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public QuadraticBezierSegment();

        public Point Point1 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty Point1Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Point2 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty Point2Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Xaml.Media.IQuadraticBezierSegment.Point1 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Point Windows.UI.Xaml.Media.IQuadraticBezierSegment.Point2 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

