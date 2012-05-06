namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Media.Capture;

    [Windows.Foundation.Metadata.Guid(0x99555575, 0x2e2e, 0x40b8, 0xb6, 0xc7, 0xf8, 0x2d, 0x10, 1, 50, 0x10), Version(0x6020000), ExclusiveTo(typeof(VideoDeviceController))]
    internal interface IVideoDeviceController : IMediaDeviceController
    {
        bool TryGetPowerlineFrequency(out PowerlineFrequency value);
        bool TrySetPowerlineFrequency([In] PowerlineFrequency value);

        MediaDeviceControl BacklightCompensation { get; }

        MediaDeviceControl Brightness { get; }

        MediaDeviceControl Contrast { get; }

        MediaDeviceControl Exposure { get; }

        IMapView<Guid, MediaDeviceControl> ExtendedProperties { get; }

        MediaDeviceControl Focus { get; }

        MediaDeviceControl Hue { get; }

        MediaDeviceControl Pan { get; }

        MediaDeviceControl Roll { get; }

        MediaDeviceControl Tilt { get; }

        MediaDeviceControl WhiteBalance { get; }

        MediaDeviceControl Zoom { get; }
    }
}

