namespace Windows.Devices.Portable
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(IServiceDeviceStatics), 0x6020000), Threading(ThreadingModel.Both)]
    public static class ServiceDevice
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetDeviceSelector([In] ServiceDeviceType serviceType);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetDeviceSelectorFromServiceId([In] Guid serviceId);
    }
}

