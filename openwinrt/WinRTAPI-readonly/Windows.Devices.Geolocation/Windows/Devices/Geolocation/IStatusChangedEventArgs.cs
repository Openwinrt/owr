namespace Windows.Devices.Geolocation
{
    using Windows.Foundation.Metadata;

    [Guid(0x3453d2da, 0x8c93, 0x4111, 0xa2, 5, 0x9a, 0xec, 0xfc, 0x9b, 0xe5, 0xc0), Version(0x6020000)]
    public interface IStatusChangedEventArgs
    {
        PositionStatus Status { get; }
    }
}

