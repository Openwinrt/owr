namespace Windows.Media.Capture
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x64e92d1f, 0xa28d, 0x425a, 0xb8, 0x4f, 0xe5, 0x68, 0x33, 0x5f, 0xf2, 0x4e), ExclusiveTo(typeof(CameraCaptureUIVideoCaptureSettings)), Version(0x6020000)]
    internal interface ICameraCaptureUIVideoCaptureSettings
    {
        bool AllowTrimming { get; [param: In] set; }

        CameraCaptureUIVideoFormat Format { get; [param: In] set; }

        float MaxDurationInSeconds { get; [param: In] set; }

        CameraCaptureUIMaxVideoResolution MaxResolution { get; [param: In] set; }
    }
}

