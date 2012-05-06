namespace Windows.Devices.Sensors
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x12c1186, 0xc3ba, 0x46bc, 0xae, 0x65, 0x7a, 0x98, 0x99, 0x6c, 0xbf, 0xb8), ExclusiveTo(typeof(OrientationSensorReadingChangedEventArgs))]
    internal interface IOrientationSensorReadingChangedEventArgs
    {
        OrientationSensorReading Reading { get; }
    }
}

