namespace Windows.Graphics.Printing
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(PrintManager)), Guid(0x58185dcd, 0xe634, 0x4654, 0x84, 240, 0xe0, 0x15, 0x2a, 130, 0x17, 0xac)]
    internal interface IPrintManagerStatic
    {
        PrintManager GetForCurrentView();
        IAsyncOperation<bool> ShowPrintUIAsync();
    }
}

