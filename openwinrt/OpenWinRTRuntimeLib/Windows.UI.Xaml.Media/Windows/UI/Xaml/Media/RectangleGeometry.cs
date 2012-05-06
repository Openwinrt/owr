namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Static(typeof(IRectangleGeometryStatics), 0x6020000), Activatable(0x6020000), Threading(ThreadingModel.Both), WebHostHidden]
    public sealed class RectangleGeometry : Geometry, IRectangleGeometry
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public RectangleGeometry();

        public Windows.Foundation.Rect Rect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty RectProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.Rect Windows.UI.Xaml.Media.IRectangleGeometry.Rect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

