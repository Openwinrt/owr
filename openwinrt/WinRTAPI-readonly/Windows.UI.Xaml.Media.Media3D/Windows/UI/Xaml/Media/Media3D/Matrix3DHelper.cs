namespace Windows.UI.Xaml.Media.Media3D
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Static(typeof(IMatrix3DHelperStatics), 0x6020000), WebHostHidden, Version(0x6020000)]
    public sealed class Matrix3DHelper : IMatrix3DHelper
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Matrix3D FromElements([In] double m11, [In] double m12, [In] double m13, [In] double m14, [In] double m21, [In] double m22, [In] double m23, [In] double m24, [In] double m31, [In] double m32, [In] double m33, [In] double m34, [In] double offsetX, [In] double offsetY, [In] double offsetZ, [In] double m44);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetHasInverse([In] Matrix3D target);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetIsIdentity([In] Matrix3D target);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Matrix3D Invert([In] Matrix3D target);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Matrix3D Multiply([In] Matrix3D matrix1, [In] Matrix3D matrix2);

        public static Matrix3D Identity { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

