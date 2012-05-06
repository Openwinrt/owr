namespace Windows.Devices.Printers.Extensions
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class PrintTaskConfiguration : IPrintTaskConfiguration
    {
        public event TypedEventHandler<PrintTaskConfiguration, PrintTaskConfigurationSaveRequestedEventArgs> SaveRequested;

        public event TypedEventHandler<PrintTaskConfiguration, PrintTaskConfigurationSaveRequestedEventArgs> Windows.Devices.Printers.Extensions.IPrintTaskConfiguration.SaveRequested;

        public object PrinterExtensionContext { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.Devices.Printers.Extensions.IPrintTaskConfiguration.PrinterExtensionContext { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

