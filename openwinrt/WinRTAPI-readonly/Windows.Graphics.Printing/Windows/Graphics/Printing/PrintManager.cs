namespace Windows.Graphics.Printing
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Static(typeof(IPrintManagerStatic), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Threading(ThreadingModel.MTA)]
    public sealed class PrintManager : IPrintManager
    {
        public event TypedEventHandler<PrintManager, PrintTaskRequestedEventArgs> PrintTaskRequested;

        public event TypedEventHandler<PrintManager, PrintTaskRequestedEventArgs> Windows.Graphics.Printing.IPrintManager.PrintTaskRequested;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static PrintManager GetForCurrentView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<bool> ShowPrintUIAsync();
    }
}

