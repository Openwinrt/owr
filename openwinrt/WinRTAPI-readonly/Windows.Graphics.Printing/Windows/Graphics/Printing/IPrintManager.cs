namespace Windows.Graphics.Printing
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xff2a9694, 0x8c99, 0x44fd, 0xae, 0x4a, 0x19, 0xd9, 170, 0x9a, 15, 10), Version(0x6020000), ExclusiveTo(typeof(PrintManager))]
    internal interface IPrintManager
    {
        event TypedEventHandler<PrintManager, PrintTaskRequestedEventArgs> PrintTaskRequested;
    }
}

