namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [Version(0x6020000), Activatable(0x6020000), ContentProperty(Name="Points"), WebHostHidden, Static(typeof(IPolyQuadraticBezierSegmentStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both)]
    public sealed class PolyQuadraticBezierSegment : PathSegment, IPolyQuadraticBezierSegment
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PolyQuadraticBezierSegment();

        public PointCollection Points { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty PointsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PointCollection Windows.UI.Xaml.Media.IPolyQuadraticBezierSegment.Points { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

