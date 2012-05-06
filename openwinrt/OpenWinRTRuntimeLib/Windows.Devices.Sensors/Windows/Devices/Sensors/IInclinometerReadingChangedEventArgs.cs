namespace Windows.Devices.Sensors
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(InclinometerReadingChangedEventArgs)), Guid(0x4ae91dc1, 0xe7eb, 0x4938, 0x85, 0x11, 0xae, 13, 0x6b, 0x44, 4, 0x38)]
    internal interface IInclinometerReadingChangedEventArgs
    {
        InclinometerReading Reading { get; }
    }
}

