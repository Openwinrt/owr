namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x688ea9b9, 0x1e4e, 0x4596, 0x86, 0xe3, 0x42, 0x8b, 0x27, 0x33, 0x4f, 0xaf), WebHostHidden, ExclusiveTo(typeof(RotateTransform))]
    internal interface IRotateTransform
    {
        double Angle { get; [param: In] set; }

        double CenterX { get; [param: In] set; }

        double CenterY { get; [param: In] set; }
    }
}

