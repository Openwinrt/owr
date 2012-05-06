namespace Windows.Devices.Sensors
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SimpleOrientationSensorOrientationChangedEventArgs)), Guid(0xbcd5c660, 0x23d4, 0x4b4c, 0xa2, 0x2e, 0xba, 0x81, 0xad, 0xe0, 0xc6, 1), Version(0x6020000)]
    internal interface ISimpleOrientationSensorOrientationChangedEventArgs
    {
        SimpleOrientation Orientation { get; }

        DateTime Timestamp { get; }
    }
}

