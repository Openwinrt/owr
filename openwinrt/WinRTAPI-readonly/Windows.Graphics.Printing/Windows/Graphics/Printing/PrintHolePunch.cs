namespace Windows.Graphics.Printing
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum PrintHolePunch
    {
        Default,
        NotAvailable,
        PrinterCustom,
        None,
        LeftEdge,
        RightEdge,
        TopEdge,
        BottomEdge
    }
}

