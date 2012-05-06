namespace Windows.Media.Devices
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Media.Capture;
    using Windows.Media.MediaProperties;

    [Windows.Foundation.Metadata.Guid(0xf6f8f5ce, 0x209a, 0x48fb, 0x86, 0xfc, 0xd4, 0x45, 120, 0xf3, 0x17, 230), Version(0x6020000)]
    public interface IMediaDeviceController
    {
        IVectorView<IMediaEncodingProperties> GetAvailableMediaStreamProperties([In] MediaStreamType mediaStreamType);
        IMediaEncodingProperties GetMediaStreamProperties([In] MediaStreamType mediaStreamType);
        IAsyncAction SetMediaStreamPropertiesAsync([In] MediaStreamType mediaStreamType, [In] IMediaEncodingProperties mediaEncodingProperties);
    }
}

