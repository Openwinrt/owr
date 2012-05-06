namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class MobileBroadbandDeviceInformation : IMobileBroadbandDeviceInformation
    {
        public Windows.Networking.NetworkOperators.CellularClass CellularClass { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MobileBroadbandRadioState CurrentRadioState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string CustomDataClass { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.NetworkOperators.DataClasses DataClasses { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string DeviceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MobileBroadbandDeviceType DeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string FirmwareInformation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Manufacturer { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Model { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.NetworkOperators.NetworkDeviceStatus NetworkDeviceStatus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string SimIccId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string SubscriberId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<string> TelephoneNumbers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.NetworkOperators.CellularClass Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation.CellularClass { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MobileBroadbandRadioState Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation.CurrentRadioState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation.CustomDataClass { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.NetworkOperators.DataClasses Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation.DataClasses { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation.DeviceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MobileBroadbandDeviceType Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation.DeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation.FirmwareInformation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation.Manufacturer { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation.Model { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.NetworkOperators.NetworkDeviceStatus Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation.NetworkDeviceStatus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation.SimIccId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation.SubscriberId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<string> Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation.TelephoneNumbers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

