namespace Windows.Graphics.Printing
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum PrintColorMode
    {
        Default,
        NotAvailable,
        PrinterCustom,
        Color,
        Grayscale,
        Monochrome
    }
}

