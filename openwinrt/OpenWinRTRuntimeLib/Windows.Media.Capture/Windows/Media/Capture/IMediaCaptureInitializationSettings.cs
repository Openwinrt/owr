namespace Windows.Media.Capture
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x9782ba70, 0xea65, 0x4900, 0x93, 0x56, 140, 0xa8, 0x87, 0x72, 0x68, 0x84), ExclusiveTo(typeof(MediaCaptureInitializationSettings)), Version(0x6020000)]
    internal interface IMediaCaptureInitializationSettings
    {
        string AudioDeviceId { get; [param: In] set; }

        Windows.Media.Capture.PhotoCaptureSource PhotoCaptureSource { get; [param: In] set; }

        bool RealTimeModeEnabled { get; [param: In] set; }

        Windows.Media.Capture.StreamingCaptureMode StreamingCaptureMode { get; [param: In] set; }

        string VideoDeviceId { get; [param: In] set; }
    }
}

