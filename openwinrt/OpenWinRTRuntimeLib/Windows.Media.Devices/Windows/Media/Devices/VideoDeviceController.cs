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

    [Version(0x6020000), Threading(ThreadingModel.MTA)]
    public sealed class VideoDeviceController : IVideoDeviceController, IMediaDeviceController, IAdvancedVideoCaptureDeviceController
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<IMediaEncodingProperties> GetAvailableMediaStreamProperties([In] MediaStreamType mediaStreamType);
        [return: Variant]
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public object GetDeviceProperty([In] string propertyId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IMediaEncodingProperties GetMediaStreamProperties([In] MediaStreamType mediaStreamType);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetDeviceProperty([In] string propertyId, [In, Variant] object propertyValue);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction SetMediaStreamPropertiesAsync([In] MediaStreamType mediaStreamType, [In] IMediaEncodingProperties mediaEncodingProperties);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool TryGetPowerlineFrequency(out PowerlineFrequency value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool TrySetPowerlineFrequency([In] PowerlineFrequency value);

        public MediaDeviceControl BacklightCompensation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Brightness { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Contrast { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Exposure { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<Guid, MediaDeviceControl> ExtendedProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Focus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Hue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Pan { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Roll { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Tilt { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl WhiteBalance { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Windows.Media.Devices.IVideoDeviceController.BacklightCompensation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Windows.Media.Devices.IVideoDeviceController.Brightness { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Windows.Media.Devices.IVideoDeviceController.Contrast { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Windows.Media.Devices.IVideoDeviceController.Exposure { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<Guid, MediaDeviceControl> Windows.Media.Devices.IVideoDeviceController.ExtendedProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Windows.Media.Devices.IVideoDeviceController.Focus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Windows.Media.Devices.IVideoDeviceController.Hue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Windows.Media.Devices.IVideoDeviceController.Pan { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Windows.Media.Devices.IVideoDeviceController.Roll { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Windows.Media.Devices.IVideoDeviceController.Tilt { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Windows.Media.Devices.IVideoDeviceController.WhiteBalance { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Windows.Media.Devices.IVideoDeviceController.Zoom { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaDeviceControl Zoom { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

