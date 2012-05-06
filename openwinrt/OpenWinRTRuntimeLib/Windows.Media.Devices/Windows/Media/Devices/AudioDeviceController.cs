namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Media.Capture;
    using Windows.Media.MediaProperties;

    [Version(0x6020000)]
    public sealed class AudioDeviceController : IAudioDeviceController, IMediaDeviceController
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<IMediaEncodingProperties> GetAvailableMediaStreamProperties([In] MediaStreamType mediaStreamType);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IMediaEncodingProperties GetMediaStreamProperties([In] MediaStreamType mediaStreamType);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction SetMediaStreamPropertiesAsync([In] MediaStreamType mediaStreamType, [In] IMediaEncodingProperties mediaEncodingProperties);

        public bool Muted { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float VolumePercent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.Media.Devices.IAudioDeviceController.Muted { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float Windows.Media.Devices.IAudioDeviceController.VolumePercent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

