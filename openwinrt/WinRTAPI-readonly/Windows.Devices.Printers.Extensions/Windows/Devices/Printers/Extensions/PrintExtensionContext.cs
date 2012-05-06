namespace Windows.Devices.Printers.Extensions
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Static(typeof(IPrintExtensionContextStatic), 0x6020000)]
    public static class PrintExtensionContext
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object FromDeviceId([In] string deviceId);
    }
}

