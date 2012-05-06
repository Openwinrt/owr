namespace Windows.Graphics.Printing
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PrintTaskRequest)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x6ff61e2e, 0x2722, 0x4240, 0xa6, 0x7c, 0xf3, 100, 0x84, 0x9a, 0x17, 0xf3)]
    internal interface IPrintTaskRequest
    {
        PrintTask CreatePrintTask([In] string title, [In] PrintTaskSourceRequestedHandler handler);
        PrintTaskRequestedDeferral GetDeferral();

        Windows.Foundation.DateTime Deadline { get; }
    }
}

