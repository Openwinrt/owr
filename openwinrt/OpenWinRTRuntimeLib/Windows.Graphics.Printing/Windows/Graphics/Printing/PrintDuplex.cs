namespace Windows.Graphics.Printing
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum PrintDuplex
    {
        Default,
        NotAvailable,
        PrinterCustom,
        OneSided,
        TwoSidedShortEdge,
        TwoSidedLongEdge
    }
}

