namespace Windows.Graphics.Printing
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum PrintBinding
    {
        Default,
        NotAvailable,
        PrinterCustom,
        None,
        Bale,
        BindBottom,
        BindLeft,
        BindRight,
        BindTop,
        Booklet,
        EdgeStitchBottom,
        EdgeStitchLeft,
        EdgeStitchRight,
        EdgeStitchTop,
        Fold,
        JogOffset,
        Trim
    }
}

