namespace Windows.Media.Capture
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Threading(ThreadingModel.STA), Activatable(0x6020000), MarshalingBehavior(MarshalingType.Inhibit)]
    public sealed class CameraCaptureUI : ICameraCaptureUI
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CameraCaptureUI();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<StorageFile> CaptureFileAsync([In] CameraCaptureUIMode mode);

        public CameraCaptureUIPhotoCaptureSettings PhotoSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CameraCaptureUIVideoCaptureSettings VideoSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CameraCaptureUIPhotoCaptureSettings Windows.Media.Capture.ICameraCaptureUI.PhotoSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CameraCaptureUIVideoCaptureSettings Windows.Media.Capture.ICameraCaptureUI.VideoSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

