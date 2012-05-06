namespace Windows.Devices.Geolocation
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(Geocoordinate)), Guid(0xee21a3aa, 0x976a, 0x4c70, 0x80, 0x3d, 8, 0x3e, 0xa5, 0x5b, 0xcb, 0xc4)]
    internal interface IGeocoordinate
    {
        double Accuracy { get; }

        IReference<double> Altitude { get; }

        IReference<double> AltitudeAccuracy { get; }

        IReference<double> Heading { get; }

        double Latitude { get; }

        double Longitude { get; }

        IReference<double> Speed { get; }

        Windows.Foundation.DateTime Timestamp { get; }
    }
}

