namespace Windows.Devices.Geolocation
{
    using Windows.Foundation.Metadata;

    [Guid(0x37859ce5, 0x9d1e, 0x46c5, 0xbf, 0x3b, 0x6a, 0xd8, 0xca, 0xc1, 160, 0x93), Version(0x6020000)]
    public interface IPositionChangedEventArgs
    {
        Geoposition Position { get; }
    }
}

