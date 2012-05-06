namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(CallControl)), Windows.Foundation.Metadata.Guid(0x3945ad5, 0x85ab, 0x40e1, 0xaf, 0x19, 0x56, 0xc9, 0x43, 3, 0xb0, 0x19)]
    internal interface ICallControlStatics
    {
        CallControl FromId([In] string deviceInterfaceId);
        CallControl GetDefault();
    }
}

