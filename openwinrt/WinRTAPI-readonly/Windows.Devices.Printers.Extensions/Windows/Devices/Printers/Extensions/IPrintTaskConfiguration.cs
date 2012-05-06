namespace Windows.Devices.Printers.Extensions
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(PrintTaskConfiguration)), Windows.Foundation.Metadata.Guid(0xe3c22451, 0x3aa4, 0x4885, 0x92, 0x40, 0x31, 0x1f, 0x5f, 0x8f, 190, 0x9d)]
    internal interface IPrintTaskConfiguration
    {
        event TypedEventHandler<PrintTaskConfiguration, PrintTaskConfigurationSaveRequestedEventArgs> SaveRequested;

        object PrinterExtensionContext { get; }
    }
}

