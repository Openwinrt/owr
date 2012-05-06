namespace Windows.Devices.Sensors
{
    using Windows.Foundation.Metadata;

    [Guid(0xfdf1895, 0x6f9e, 0x42ce, 0x8d, 0x58, 0x38, 140, 10, 0xb8, 0x35, 0x6d), ExclusiveTo(typeof(GyrometerReadingChangedEventArgs)), Version(0x6020000)]
    internal interface IGyrometerReadingChangedEventArgs
    {
        GyrometerReading Reading { get; }
    }
}

