namespace Windows.Media.Capture
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), DualApiPartition(version=0x6020000), Version(0x6020000), Activatable(0x6020000)]
    public sealed class MediaCaptureInitializationSettings : IMediaCaptureInitializationSettings
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public MediaCaptureInitializationSettings();

        public string AudioDeviceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Media.Capture.PhotoCaptureSource PhotoCaptureSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool RealTimeModeEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Media.Capture.StreamingCaptureMode StreamingCaptureMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string VideoDeviceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Media.Capture.IMediaCaptureInitializationSettings.AudioDeviceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Media.Capture.PhotoCaptureSource Windows.Media.Capture.IMediaCaptureInitializationSettings.PhotoCaptureSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.Media.Capture.IMediaCaptureInitializationSettings.RealTimeModeEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Media.Capture.StreamingCaptureMode Windows.Media.Capture.IMediaCaptureInitializationSettings.StreamingCaptureMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Media.Capture.IMediaCaptureInitializationSettings.VideoDeviceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

