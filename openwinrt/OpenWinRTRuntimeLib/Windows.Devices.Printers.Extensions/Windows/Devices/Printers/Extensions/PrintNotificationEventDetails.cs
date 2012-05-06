namespace Windows.Devices.Printers.Extensions
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class PrintNotificationEventDetails : IPrintNotificationEventDetails
    {
        public string EventData { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string PrinterName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Devices.Printers.Extensions.IPrintNotificationEventDetails.EventData { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Devices.Printers.Extensions.IPrintNotificationEventDetails.PrinterName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

