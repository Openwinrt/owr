namespace Windows.Media.MediaProperties
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;
    using Windows.Storage.Streams;

    [Version(0x6020000), Static(typeof(IMediaEncodingProfileStatics), 0x6020000), Threading(ThreadingModel.MTA), DualApiPartition(version=0x6020000), Activatable(0x6020000)]
    public sealed class MediaEncodingProfile : IMediaEncodingProfile
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public MediaEncodingProfile();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<MediaEncodingProfile> CreateFromFileAsync([In] IStorageFile file);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<MediaEncodingProfile> CreateFromStreamAsync([In] IRandomAccessStream stream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static MediaEncodingProfile CreateM4a([In] AudioEncodingQuality quality);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static MediaEncodingProfile CreateMp3([In] AudioEncodingQuality quality);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static MediaEncodingProfile CreateMp4([In] VideoEncodingQuality quality);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static MediaEncodingProfile CreateWma([In] AudioEncodingQuality quality);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static MediaEncodingProfile CreateWmv([In] VideoEncodingQuality quality);

        public AudioEncodingProperties Audio { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ContainerEncodingProperties Container { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public VideoEncodingProperties Video { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public AudioEncodingProperties Windows.Media.MediaProperties.IMediaEncodingProfile.Audio { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ContainerEncodingProperties Windows.Media.MediaProperties.IMediaEncodingProfile.Container { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public VideoEncodingProperties Windows.Media.MediaProperties.IMediaEncodingProfile.Video { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

