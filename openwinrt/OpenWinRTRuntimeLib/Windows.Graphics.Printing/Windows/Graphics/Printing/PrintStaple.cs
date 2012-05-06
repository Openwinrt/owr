namespace Windows.Graphics.Printing
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum PrintStaple
    {
        Default,
        NotAvailable,
        PrinterCustom,
        None,
        StapleTopLeft,
        StapleTopRight,
        StapleBottomLeft,
        StapleBottomRight,
        StapleDualLeft,
        StapleDualRight,
        StapleDualTop,
        StapleDualBottom,
        SaddleStitch
    }
}

