namespace Windows.Graphics.Printing
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum PrintQuality
    {
        Default,
        NotAvailable,
        PrinterCustom,
        Automatic,
        Draft,
        Fax,
        High,
        Normal,
        Photographic,
        Text
    }
}

