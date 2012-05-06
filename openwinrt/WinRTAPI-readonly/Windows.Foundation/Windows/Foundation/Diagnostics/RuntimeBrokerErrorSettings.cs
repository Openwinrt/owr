namespace Windows.Foundation.Diagnostics
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000)]
    public sealed class RuntimeBrokerErrorSettings : IErrorReportingSettings
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public RuntimeBrokerErrorSettings();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ErrorOptions GetErrorOptions();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetErrorOptions([In] ErrorOptions value);
    }
}

