namespace Windows.Graphics.Printing
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x810cd3cb, 0xb410, 0x4282, 160, 0x73, 90, 0xc3, 120, 0x23, 0x41, 0x74), ExclusiveTo(typeof(PrintTaskProgressingEventArgs)), Version(0x6020000)]
    internal interface IPrintTaskProgressingEventArgs
    {
        uint DocumentPageCount { get; }
    }
}

