namespace Windows.Devices.Printers.Extensions
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class PrintTaskConfigurationSaveRequestedDeferral : IPrintTaskConfigurationSaveRequestedDeferral
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Complete();
    }
}

