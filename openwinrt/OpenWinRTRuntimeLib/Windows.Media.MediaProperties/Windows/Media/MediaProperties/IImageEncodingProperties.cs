namespace Windows.Media.MediaProperties
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ImageEncodingProperties)), Windows.Foundation.Metadata.Guid(0x78625635, 0xf331, 0x4189, 0xb1, 0xc3, 180, 0x8d, 90, 0xe0, 0x34, 0xf1)]
    internal interface IImageEncodingProperties : IMediaEncodingProperties
    {
        uint Height { get; [param: In] set; }

        uint Width { get; [param: In] set; }
    }
}

