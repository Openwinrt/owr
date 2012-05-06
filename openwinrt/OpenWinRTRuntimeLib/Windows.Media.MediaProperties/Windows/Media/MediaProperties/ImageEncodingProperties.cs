namespace Windows.Media.MediaProperties
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000), Static(typeof(IImageEncodingPropertiesStatics), 0x6020000), Activatable(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class ImageEncodingProperties : IImageEncodingProperties, IMediaEncodingProperties
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ImageEncodingProperties();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ImageEncodingProperties CreateJpeg();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ImageEncodingProperties CreateJpegXR();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ImageEncodingProperties CreatePng();

        public uint Height { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public MediaPropertySet Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Subtype { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Width { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Media.MediaProperties.IImageEncodingProperties.Height { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Media.MediaProperties.IImageEncodingProperties.Width { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public MediaPropertySet Windows.Media.MediaProperties.IMediaEncodingProperties.Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Media.MediaProperties.IMediaEncodingProperties.Subtype { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Media.MediaProperties.IMediaEncodingProperties.Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

