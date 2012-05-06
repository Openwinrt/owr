namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Composable(typeof(IGeometryFactory), CompositionType.Protected, 0x6020000), Version(0x6020000), Static(typeof(IGeometryStatics), 0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class Geometry : DependencyObject, IGeometry
    {
        public Rect Bounds { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Geometry Empty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static double StandardFlatteningTolerance { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Transform Transform { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty TransformProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Rect Windows.UI.Xaml.Media.IGeometry.Bounds { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Transform Windows.UI.Xaml.Media.IGeometry.Transform { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

