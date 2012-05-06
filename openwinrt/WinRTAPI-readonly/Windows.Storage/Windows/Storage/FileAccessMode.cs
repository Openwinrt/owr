namespace Windows.Storage
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum FileAccessMode
    {
        Read,
        ReadWrite,
        ReadWriteUnsafe,
        ReadWriteNoCopyOnWrite
    }
}

