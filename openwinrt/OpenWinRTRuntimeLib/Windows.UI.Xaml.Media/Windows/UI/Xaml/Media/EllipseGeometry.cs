namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Activatable(0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Static(typeof(IEllipseGeometryStatics), 0x6020000), Threading(ThreadingModel.Both)]
    public sealed class EllipseGeometry : Geometry, IEllipseGeometry
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public EllipseGeometry();

        public Point Center { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty CenterProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double RadiusX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty RadiusXProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double RadiusY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty RadiusYProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Xaml.Media.IEllipseGeometry.Center { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Media.IEllipseGeometry.RadiusX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Media.IEllipseGeometry.RadiusY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

