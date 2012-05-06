namespace Windows.Devices.Printers.Extensions
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PrintTaskConfigurationSaveRequest)), Windows.Foundation.Metadata.Guid(0xeeaf2fcb, 0x621e, 0x4b62, 0xac, 0x77, 0xb2, 0x81, 0xcc, 0xe0, 0x8d, 0x60), Version(0x6020000)]
    internal interface IPrintTaskConfigurationSaveRequest
    {
        void Cancel();
        PrintTaskConfigurationSaveRequestedDeferral GetDeferral();
        void Save([In] object printerExtensionContext);

        Windows.Foundation.DateTime Deadline { get; }
    }
}

