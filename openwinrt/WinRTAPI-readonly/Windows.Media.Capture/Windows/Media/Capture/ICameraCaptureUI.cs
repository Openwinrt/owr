namespace Windows.Media.Capture
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(CameraCaptureUI)), Windows.Foundation.Metadata.Guid(0x48587540, 0x6f93, 0x4bb4, 0xb8, 0xf3, 0xe8, 0x9e, 0x48, 0x94, 140, 0x91), Version(0x6020000)]
    internal interface ICameraCaptureUI
    {
        IAsyncOperation<StorageFile> CaptureFileAsync([In] CameraCaptureUIMode mode);

        CameraCaptureUIPhotoCaptureSettings PhotoSettings { get; }

        CameraCaptureUIVideoCaptureSettings VideoSettings { get; }
    }
}

