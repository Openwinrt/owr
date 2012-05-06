namespace Windows.Devices.Printers.Extensions
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe70d9fc1, 0xff79, 0x4aa4, 140, 0x9b, 12, 0x93, 0xae, 0xdf, 0xde, 0x8a), ExclusiveTo(typeof(PrintExtensionContext))]
    internal interface IPrintExtensionContextStatic
    {
        object FromDeviceId([In] string deviceId);
    }
}

