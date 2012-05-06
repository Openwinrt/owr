namespace Windows.Devices.Input
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Guid(0x93c9bafc, 0xebcb, 0x467e, 130, 0xc6, 0x27, 0x6f, 0xea, 0xe3, 0x6b, 90), Version(0x6020000), ExclusiveTo(typeof(PointerDevice))]
    internal interface IPointerDevice
    {
        bool IsIntegrated { get; }

        uint MaxContacts { get; }

        Rect PhysicalDeviceRect { get; }

        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }

        Rect ScreenRect { get; }

        IVectorView<PointerDeviceUsage> SupportedUsages { get; }
    }
}

