namespace Windows.Media.Capture
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class MediaCaptureSettings : IMediaCaptureSettings
    {
        public string AudioDeviceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Media.Capture.PhotoCaptureSource PhotoCaptureSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool RealTimeModeEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Media.Capture.StreamingCaptureMode StreamingCaptureMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Media.Capture.VideoDeviceCharacteristic VideoDeviceCharacteristic { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string VideoDeviceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Media.Capture.IMediaCaptureSettings.AudioDeviceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Media.Capture.PhotoCaptureSource Windows.Media.Capture.IMediaCaptureSettings.PhotoCaptureSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Media.Capture.IMediaCaptureSettings.RealTimeModeEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Media.Capture.StreamingCaptureMode Windows.Media.Capture.IMediaCaptureSettings.StreamingCaptureMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Media.Capture.VideoDeviceCharacteristic Windows.Media.Capture.IMediaCaptureSettings.VideoDeviceCharacteristic { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Media.Capture.IMediaCaptureSettings.VideoDeviceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

