namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [Static(typeof(IPolyBezierSegmentStatics), 0x6020000), Activatable(0x6020000), Threading(ThreadingModel.Both), ContentProperty(Name="Points"), WebHostHidden, Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class PolyBezierSegment : PathSegment, IPolyBezierSegment
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PolyBezierSegment();

        public PointCollection Points { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty PointsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PointCollection Windows.UI.Xaml.Media.IPolyBezierSegment.Points { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

