namespace Windows.Networking.Proximity
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ProximityDevice)), Windows.Foundation.Metadata.Guid(0x914ba01d, 0xf6e1, 0x47c4, 0xa1, 0x4c, 20, 0x8a, 0x19, 3, 0xd0, 0xc6), Version(0x6020000)]
    internal interface IProximityDeviceStatics
    {
        ProximityDevice FromId([In] string deviceInterfaceId);
        ProximityDevice GetDefault();
        string GetDeviceSelector();
    }
}

