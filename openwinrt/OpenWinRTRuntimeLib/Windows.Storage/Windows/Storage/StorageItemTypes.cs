namespace Windows.Storage
{
    using System;
    using Windows.Foundation.Metadata;

    [Flags, Version(0x6020000)]
    public enum StorageItemTypes : uint
    {
        File = 1,
        Folder = 2,
        None = 0
    }
}

