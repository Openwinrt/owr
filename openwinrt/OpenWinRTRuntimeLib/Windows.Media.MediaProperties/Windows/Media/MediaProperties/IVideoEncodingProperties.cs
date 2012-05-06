namespace Windows.Media.MediaProperties
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(VideoEncodingProperties)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x76ee6c9a, 0x37c2, 0x4f2a, 0x88, 10, 0x12, 130, 0xbb, 180, 0x37, 0x3d)]
    internal interface IVideoEncodingProperties : IMediaEncodingProperties
    {
        uint Bitrate { get; [param: In] set; }

        MediaRatio FrameRate { get; }

        uint Height { get; [param: In] set; }

        MediaRatio PixelAspectRatio { get; }

        uint Width { get; [param: In] set; }
    }
}

