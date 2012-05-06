namespace Windows.Media.MediaProperties
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Activatable(0x6020000), Version(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class VideoEncodingProperties : IVideoEncodingProperties, IMediaEncodingProperties
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public VideoEncodingProperties();

        public uint Bitrate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public MediaRatio FrameRate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Height { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public MediaRatio PixelAspectRatio { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaPropertySet Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Subtype { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Width { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public MediaPropertySet Windows.Media.MediaProperties.IMediaEncodingProperties.Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Media.MediaProperties.IMediaEncodingProperties.Subtype { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Media.MediaProperties.IMediaEncodingProperties.Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Media.MediaProperties.IVideoEncodingProperties.Bitrate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public MediaRatio Windows.Media.MediaProperties.IVideoEncodingProperties.FrameRate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Media.MediaProperties.IVideoEncodingProperties.Height { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public MediaRatio Windows.Media.MediaProperties.IVideoEncodingProperties.PixelAspectRatio { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Media.MediaProperties.IVideoEncodingProperties.Width { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

