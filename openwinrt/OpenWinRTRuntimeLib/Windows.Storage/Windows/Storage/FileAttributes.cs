namespace Windows.Storage
{
    using System;
    using Windows.Foundation.Metadata;

    [Flags, Version(0x6020000)]
    public enum FileAttributes : uint
    {
        Archive = 0x20,
        Directory = 0x10,
        Normal = 0,
        ReadOnly = 1,
        Temporary = 0x100
    }
}

