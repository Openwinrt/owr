namespace Windows.UI.Xaml.Shapes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;

    [Static(typeof(IPolylineStatics), 0x6020000), Threading(ThreadingModel.Both), Activatable(0x6020000), Version(0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class Polyline : Shape, IPolyline
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Polyline();

        public Windows.UI.Xaml.Media.FillRule FillRule { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FillRuleProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PointCollection Points { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty PointsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.FillRule Windows.UI.Xaml.Shapes.IPolyline.FillRule { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PointCollection Windows.UI.Xaml.Shapes.IPolyline.Points { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

