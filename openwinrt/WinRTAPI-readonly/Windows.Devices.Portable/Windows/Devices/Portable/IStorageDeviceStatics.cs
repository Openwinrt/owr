namespace Windows.Devices.Portable
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Windows.Foundation.Metadata.Guid(0x5ece44ee, 0x1b23, 0x4dd2, 0x86, 0x52, 0xbc, 0x16, 0x4f, 0, 0x31, 40), ExclusiveTo(typeof(StorageDevice)), Version(0x6020000)]
    internal interface IStorageDeviceStatics
    {
        StorageFolder FromId([In] string interfaceId);
        string GetDeviceSelector();
    }
}

