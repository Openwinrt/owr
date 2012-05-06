namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;
    using Windows.UI.Xaml.Media.Media3D;

    [Static(typeof(IMatrix3DProjectionStatics), 0x6020000), WebHostHidden, Activatable(0x6020000), Threading(ThreadingModel.Both), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), ContentProperty(Name="ProjectionMatrix")]
    public sealed class Matrix3DProjection : Projection, IMatrix3DProjection
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Matrix3DProjection();

        public Matrix3D ProjectionMatrix { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ProjectionMatrixProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Matrix3D Windows.UI.Xaml.Media.IMatrix3DProjection.ProjectionMatrix { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

