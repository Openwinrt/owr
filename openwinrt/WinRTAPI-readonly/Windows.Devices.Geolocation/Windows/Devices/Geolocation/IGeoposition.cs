namespace Windows.Devices.Geolocation
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Geoposition)), Guid(0xc18d0454, 0x7d41, 0x4ff7, 0xa9, 0x57, 0x9d, 0xff, 180, 0xef, 0x7f, 0x5b), Version(0x6020000)]
    internal interface IGeoposition
    {
        Windows.Devices.Geolocation.CivicAddress CivicAddress { get; }

        Geocoordinate Coordinate { get; }
    }
}

