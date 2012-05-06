namespace Windows.Devices.Sensors
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(LightSensorReadingChangedEventArgs)), Guid(0xa3a2f4cf, 0x258b, 0x420c, 0xb8, 0xab, 0x8e, 0xdd, 0x60, 30, 0xcf, 80)]
    internal interface ILightSensorReadingChangedEventArgs
    {
        LightSensorReading Reading { get; }
    }
}

