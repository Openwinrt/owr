namespace Windows.Media.Transcoding
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum TranscodeFailureReason
    {
        None,
        Unknown,
        InvalidProfile,
        CodecNotFound
    }
}

