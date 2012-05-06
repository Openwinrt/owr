namespace Windows.Graphics.Imaging
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum TiffCompressionMode
    {
        Automatic,
        None,
        Ccitt3,
        Ccitt4,
        Lzw,
        Rle,
        Zip,
        LzwhDifferencing
    }
}

