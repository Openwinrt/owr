namespace Windows.Media.Capture
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class MediaCaptureFailedEventArgs : IMediaCaptureFailedEventArgs
    {
        public uint Code { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Message { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Media.Capture.IMediaCaptureFailedEventArgs.Code { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Media.Capture.IMediaCaptureFailedEventArgs.Message { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

