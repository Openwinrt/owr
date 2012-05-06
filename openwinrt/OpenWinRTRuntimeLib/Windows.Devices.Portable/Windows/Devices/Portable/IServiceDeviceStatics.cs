namespace Windows.Devices.Portable
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ServiceDevice)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa88214e1, 0x59c7, 0x4a20, 0xab, 0xa6, 0x9f, 0x67, 7, 0x93, 0x72, 0x30)]
    internal interface IServiceDeviceStatics
    {
        string GetDeviceSelector([In] ServiceDeviceType serviceType);
        string GetDeviceSelectorFromServiceId([In] Guid serviceId);
    }
}

