namespace Windows.Media.Capture
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x1d83aafe, 0x6d45, 0x4477, 0x8d, 0xc4, 0xac, 0x5b, 0xc0, 0x1c, 0x40, 0x91), Version(0x6020000), ExclusiveTo(typeof(MediaCaptureSettings))]
    internal interface IMediaCaptureSettings
    {
        string AudioDeviceId { get; }

        Windows.Media.Capture.PhotoCaptureSource PhotoCaptureSource { get; }

        bool RealTimeModeEnabled { get; }

        Windows.Media.Capture.StreamingCaptureMode StreamingCaptureMode { get; }

        Windows.Media.Capture.VideoDeviceCharacteristic VideoDeviceCharacteristic { get; }

        string VideoDeviceId { get; }
    }
}

