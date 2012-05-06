namespace Windows.Devices.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xd8b89aa1, 0xd1c6, 0x416e, 0xbd, 0x8d, 0x57, 0x90, 0x91, 0x4d, 0xc5, 0x63), ExclusiveTo(typeof(PointerDevice)), Version(0x6020000)]
    internal interface IPointerDeviceStatics
    {
        PointerDevice GetPointerDevice([In] uint pointerId);
        IVectorView<PointerDevice> GetPointerDevices();
    }
}

