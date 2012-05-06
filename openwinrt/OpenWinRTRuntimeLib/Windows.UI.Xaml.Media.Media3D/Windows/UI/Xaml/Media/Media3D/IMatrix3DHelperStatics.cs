namespace Windows.UI.Xaml.Media.Media3D
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Matrix3DHelper)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x9264545e, 0xe158, 0x4e74, 0x88, 0x99, 0x68, 0x91, 0x60, 0xbd, 0x2f, 140), Version(0x6020000)]
    internal interface IMatrix3DHelperStatics
    {
        Matrix3D FromElements([In] double m11, [In] double m12, [In] double m13, [In] double m14, [In] double m21, [In] double m22, [In] double m23, [In] double m24, [In] double m31, [In] double m32, [In] double m33, [In] double m34, [In] double offsetX, [In] double offsetY, [In] double offsetZ, [In] double m44);
        bool GetHasInverse([In] Matrix3D target);
        bool GetIsIdentity([In] Matrix3D target);
        Matrix3D Invert([In] Matrix3D target);
        Matrix3D Multiply([In] Matrix3D matrix1, [In] Matrix3D matrix2);

        Matrix3D Identity { get; }
    }
}

