namespace Windows.Graphics.Imaging
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum PngFilterMode
    {
        Automatic,
        None,
        Sub,
        Up,
        Average,
        Paeth,
        Adaptive
    }
}

