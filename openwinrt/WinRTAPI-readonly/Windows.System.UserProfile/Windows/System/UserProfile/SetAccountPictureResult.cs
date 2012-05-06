namespace Windows.System.UserProfile
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum SetAccountPictureResult
    {
        Success,
        ChangeDisabled,
        LargeOrDynamicError,
        VideoFrameSizeError,
        FileSizeError,
        Failure
    }
}

