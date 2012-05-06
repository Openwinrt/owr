namespace Windows.Devices.Printers.Extensions
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class PrintTaskConfigurationSaveRequest : IPrintTaskConfigurationSaveRequest
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Cancel();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PrintTaskConfigurationSaveRequestedDeferral GetDeferral();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Save([In] object printerExtensionContext);

        public Windows.Foundation.DateTime Deadline { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Devices.Printers.Extensions.IPrintTaskConfigurationSaveRequest.Deadline { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

