namespace Windows.Media.MediaProperties
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xd2d0fee5, 0x8929, 0x401d, 0xac, 120, 0x7d, 0x35, 0x7e, 0x37, 0x81, 0x63), Version(0x6020000), ExclusiveTo(typeof(MediaRatio))]
    internal interface IMediaRatio
    {
        uint Denominator { get; [param: In] set; }

        uint Numerator { get; [param: In] set; }
    }
}

