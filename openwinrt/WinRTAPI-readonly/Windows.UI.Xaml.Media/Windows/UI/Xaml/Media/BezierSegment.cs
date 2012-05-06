namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Static(typeof(IBezierSegmentStatics), 0x6020000), Threading(ThreadingModel.Both), Activatable(0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden]
    public sealed class BezierSegment : PathSegment, IBezierSegment
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public BezierSegment();

        public Point Point1 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty Point1Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Point2 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty Point2Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Point3 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty Point3Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Xaml.Media.IBezierSegment.Point1 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Point Windows.UI.Xaml.Media.IBezierSegment.Point2 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Point Windows.UI.Xaml.Media.IBezierSegment.Point3 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

