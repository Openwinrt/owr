namespace Windows.Media.Capture
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xb9f5be97, 0x3472, 0x46a8, 0x8a, 0x9e, 4, 0xce, 0x42, 0xcc, 0xc9, 0x7d), ExclusiveTo(typeof(CameraCaptureUIPhotoCaptureSettings)), Version(0x6020000)]
    internal interface ICameraCaptureUIPhotoCaptureSettings
    {
        bool AllowCropping { get; [param: In] set; }

        Size CroppedAspectRatio { get; [param: In] set; }

        Size CroppedSizeInPixels { get; [param: In] set; }

        CameraCaptureUIPhotoFormat Format { get; [param: In] set; }

        CameraCaptureUIMaxPhotoResolution MaxResolution { get; [param: In] set; }
    }
}

