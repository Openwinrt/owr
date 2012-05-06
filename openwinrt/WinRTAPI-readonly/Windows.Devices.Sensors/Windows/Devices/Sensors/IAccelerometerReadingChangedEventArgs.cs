namespace Windows.Devices.Sensors
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(AccelerometerReadingChangedEventArgs)), Guid(0x95c65b, 0xb6ac, 0x475a, 0x9f, 0x44, 0x8b, 50, 0xd3, 90, 0x3f, 0x25), Version(0x6020000)]
    internal interface IAccelerometerReadingChangedEventArgs
    {
        AccelerometerReading Reading { get; }
    }
}

