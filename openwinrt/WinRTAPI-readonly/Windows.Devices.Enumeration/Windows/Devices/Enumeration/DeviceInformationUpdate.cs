namespace Windows.Devices.Enumeration
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class DeviceInformationUpdate : IDeviceInformationUpdate
    {
        public string Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, object> Properties { [return: HasVariant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Devices.Enumeration.IDeviceInformationUpdate.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, object> Windows.Devices.Enumeration.IDeviceInformationUpdate.Properties { [return: HasVariant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

