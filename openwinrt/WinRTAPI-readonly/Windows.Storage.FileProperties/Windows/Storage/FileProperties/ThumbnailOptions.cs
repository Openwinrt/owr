namespace Windows.Storage.FileProperties
{
    using System;
    using Windows.Foundation.Metadata;

    [Flags, Version(0x6020000)]
    public enum ThumbnailOptions : uint
    {
        None = 0,
        ResizeThumbnail = 2,
        ReturnOnlyIfCached = 1,
        UseCurrentScale = 4
    }
}

