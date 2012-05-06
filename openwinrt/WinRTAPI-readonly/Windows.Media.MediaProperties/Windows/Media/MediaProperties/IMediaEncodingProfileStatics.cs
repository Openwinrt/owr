namespace Windows.Media.MediaProperties
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;
    using Windows.Storage.Streams;

    [Windows.Foundation.Metadata.Guid(0x197f352c, 0x2ede, 0x4a45, 0xa8, 150, 0x81, 0x7a, 0x48, 0x54, 0xf8, 0xfe), ExclusiveTo(typeof(MediaEncodingProfile)), Version(0x6020000)]
    internal interface IMediaEncodingProfileStatics
    {
        IAsyncOperation<MediaEncodingProfile> CreateFromFileAsync([In] IStorageFile file);
        IAsyncOperation<MediaEncodingProfile> CreateFromStreamAsync([In] IRandomAccessStream stream);
        MediaEncodingProfile CreateM4a([In] AudioEncodingQuality quality);
        MediaEncodingProfile CreateMp3([In] AudioEncodingQuality quality);
        MediaEncodingProfile CreateMp4([In] VideoEncodingQuality quality);
        MediaEncodingProfile CreateWma([In] AudioEncodingQuality quality);
        MediaEncodingProfile CreateWmv([In] VideoEncodingQuality quality);
    }
}

