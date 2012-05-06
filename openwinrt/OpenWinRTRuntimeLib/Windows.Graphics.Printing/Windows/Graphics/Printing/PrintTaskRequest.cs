namespace Windows.Graphics.Printing
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class PrintTaskRequest : IPrintTaskRequest
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PrintTask CreatePrintTask([In] string title, [In] PrintTaskSourceRequestedHandler handler);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PrintTaskRequestedDeferral GetDeferral();

        public Windows.Foundation.DateTime Deadline { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Graphics.Printing.IPrintTaskRequest.Deadline { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

