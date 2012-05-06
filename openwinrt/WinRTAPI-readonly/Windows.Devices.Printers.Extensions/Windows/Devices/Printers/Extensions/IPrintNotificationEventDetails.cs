namespace Windows.Devices.Printers.Extensions
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe00e4c8a, 0x4828, 0x4da1, 0x8b, 0xb8, 0x86, 0x72, 0xdf, 0x85, 0x15, 0xe7), ExclusiveTo(typeof(PrintNotificationEventDetails))]
    internal interface IPrintNotificationEventDetails
    {
        string EventData { get; [param: In] set; }

        string PrinterName { get; }
    }
}

