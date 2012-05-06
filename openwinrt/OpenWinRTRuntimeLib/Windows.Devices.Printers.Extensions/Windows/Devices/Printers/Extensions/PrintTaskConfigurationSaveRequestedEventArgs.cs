namespace Windows.Devices.Printers.Extensions
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class PrintTaskConfigurationSaveRequestedEventArgs : IPrintTaskConfigurationSaveRequestedEventArgs
    {
        public PrintTaskConfigurationSaveRequest Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PrintTaskConfigurationSaveRequest Windows.Devices.Printers.Extensions.IPrintTaskConfigurationSaveRequestedEventArgs.Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

