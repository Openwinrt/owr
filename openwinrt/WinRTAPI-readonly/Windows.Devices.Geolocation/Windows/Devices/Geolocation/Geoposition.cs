namespace Windows.Devices.Geolocation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class Geoposition : IGeoposition
    {
        public Windows.Devices.Geolocation.CivicAddress CivicAddress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Geocoordinate Coordinate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Geolocation.CivicAddress Windows.Devices.Geolocation.IGeoposition.CivicAddress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Geocoordinate Windows.Devices.Geolocation.IGeoposition.Coordinate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

