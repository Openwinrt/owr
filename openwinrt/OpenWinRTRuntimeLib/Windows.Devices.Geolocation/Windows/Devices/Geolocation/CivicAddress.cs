namespace Windows.Devices.Geolocation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class CivicAddress : ICivicAddress
    {
        public string City { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Country { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string PostalCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string State { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Devices.Geolocation.ICivicAddress.City { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Devices.Geolocation.ICivicAddress.Country { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Devices.Geolocation.ICivicAddress.PostalCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Devices.Geolocation.ICivicAddress.State { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Devices.Geolocation.ICivicAddress.Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

