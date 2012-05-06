namespace Windows.UI.Xaml.Shapes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;

    [Static(typeof(IPolygonStatics), 0x6020000), Threading(ThreadingModel.Both), Version(0x6020000), WebHostHidden, Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class Polygon : Shape, IPolygon
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Polygon();

        public Windows.UI.Xaml.Media.FillRule FillRule { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FillRuleProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PointCollection Points { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty PointsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.FillRule Windows.UI.Xaml.Shapes.IPolygon.FillRule { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PointCollection Windows.UI.Xaml.Shapes.IPolygon.Points { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

