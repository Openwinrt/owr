namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Media.Media3D;

    [ExclusiveTo(typeof(Matrix3DProjection)), Windows.Foundation.Metadata.Guid(0x6f03e149, 0xbfc9, 0x4c01, 0xb5, 120, 80, 0x33, 140, 0xec, 0x97, 0xfc), Version(0x6020000), WebHostHidden]
    internal interface IMatrix3DProjection
    {
        Matrix3D ProjectionMatrix { get; [param: In] set; }
    }
}

