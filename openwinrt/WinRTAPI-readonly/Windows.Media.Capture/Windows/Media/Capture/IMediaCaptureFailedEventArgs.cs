namespace Windows.Media.Capture
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(MediaCaptureFailedEventArgs)), Guid(0x80fde3f4, 0x54c4, 0x42c0, 0x8d, 0x19, 0xce, 0xa1, 0xa8, 0x7c, 0xa1, 0x8b)]
    internal interface IMediaCaptureFailedEventArgs
    {
        uint Code { get; }

        string Message { get; }
    }
}

