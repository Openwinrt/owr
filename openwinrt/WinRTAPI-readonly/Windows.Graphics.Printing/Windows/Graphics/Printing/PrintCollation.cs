namespace Windows.Graphics.Printing
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum PrintCollation
    {
        Default,
        NotAvailable,
        PrinterCustom,
        Collated,
        Uncollated
    }
}

