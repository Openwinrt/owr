namespace Windows.Devices.Sensors
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(CompassReadingChangedEventArgs)), Guid(0x8f1549b0, 0xe8bc, 0x4c7e, 0xb0, 9, 0x4e, 0x41, 0xdf, 0x13, 0x70, 0x72)]
    internal interface ICompassReadingChangedEventArgs
    {
        CompassReading Reading { get; }
    }
}

