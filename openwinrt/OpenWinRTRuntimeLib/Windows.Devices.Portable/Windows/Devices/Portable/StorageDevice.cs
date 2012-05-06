namespace Windows.Devices.Portable
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Threading(ThreadingModel.Both), Static(typeof(IStorageDeviceStatics), 0x6020000), Version(0x6020000)]
    public static class StorageDevice
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static StorageFolder FromId([In] string interfaceId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetDeviceSelector();
    }
}

