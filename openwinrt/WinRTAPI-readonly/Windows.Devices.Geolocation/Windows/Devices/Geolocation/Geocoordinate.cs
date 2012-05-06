namespace Windows.Devices.Geolocation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class Geocoordinate : IGeocoordinate
    {
        public double Accuracy { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<double> Altitude { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<double> AltitudeAccuracy { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<double> Heading { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Latitude { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Longitude { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<double> Speed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Devices.Geolocation.IGeocoordinate.Accuracy { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<double> Windows.Devices.Geolocation.IGeocoordinate.Altitude { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<double> Windows.Devices.Geolocation.IGeocoordinate.AltitudeAccuracy { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<double> Windows.Devices.Geolocation.IGeocoordinate.Heading { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Devices.Geolocation.IGeocoordinate.Latitude { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Devices.Geolocation.IGeocoordinate.Longitude { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<double> Windows.Devices.Geolocation.IGeocoordinate.Speed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Devices.Geolocation.IGeocoordinate.Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

