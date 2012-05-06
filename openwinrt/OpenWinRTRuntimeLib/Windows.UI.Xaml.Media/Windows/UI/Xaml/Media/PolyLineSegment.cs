namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [Activatable(0x6020000), ContentProperty(Name="Points"), Threading(ThreadingModel.Both), WebHostHidden, Static(typeof(IPolyLineSegmentStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class PolyLineSegment : PathSegment, IPolyLineSegment
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PolyLineSegment();

        public PointCollection Points { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty PointsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PointCollection Windows.UI.Xaml.Media.IPolyLineSegment.Points { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

