namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Media.Media3D;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe6f82bfa, 0x6726, 0x469a, 0xb2, 0x59, 0xa5, 0x18, 0x83, 0x47, 0xca, 0x8f), ExclusiveTo(typeof(PlaneProjection)), WebHostHidden]
    internal interface IPlaneProjection
    {
        double CenterOfRotationX { get; [param: In] set; }

        double CenterOfRotationY { get; [param: In] set; }

        double CenterOfRotationZ { get; [param: In] set; }

        double GlobalOffsetX { get; [param: In] set; }

        double GlobalOffsetY { get; [param: In] set; }

        double GlobalOffsetZ { get; [param: In] set; }

        double LocalOffsetX { get; [param: In] set; }

        double LocalOffsetY { get; [param: In] set; }

        double LocalOffsetZ { get; [param: In] set; }

        Matrix3D ProjectionMatrix { get; }

        double RotationX { get; [param: In] set; }

        double RotationY { get; [param: In] set; }

        double RotationZ { get; [param: In] set; }
    }
}

