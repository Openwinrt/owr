namespace Windows.Storage.Compression
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum CompressAlgorithm
    {
        InvalidAlgorithm,
        NullAlgorithm,
        Mszip,
        Xpress,
        XpressHuff,
        Lzms
    }
}

