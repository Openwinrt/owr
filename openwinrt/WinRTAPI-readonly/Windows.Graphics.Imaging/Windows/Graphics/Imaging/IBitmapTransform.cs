namespace Windows.Graphics.Imaging
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xae755344, 0xe268, 0x4d35, 0xad, 0xcf, 0xe9, 0x95, 0xd3, 0x1a, 0x8d, 0x34), Version(0x6020000), ExclusiveTo(typeof(BitmapTransform))]
    internal interface IBitmapTransform
    {
        BitmapBounds Bounds { get; [param: In] set; }

        BitmapFlip Flip { get; [param: In] set; }

        BitmapInterpolationMode InterpolationMode { get; [param: In] set; }

        BitmapRotation Rotation { get; [param: In] set; }

        uint ScaledHeight { get; [param: In] set; }

        uint ScaledWidth { get; [param: In] set; }
    }
}

