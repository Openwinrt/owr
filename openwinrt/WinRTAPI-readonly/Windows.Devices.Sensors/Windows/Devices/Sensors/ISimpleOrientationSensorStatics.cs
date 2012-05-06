namespace Windows.Devices.Sensors
{
    using Windows.Foundation.Metadata;

    [Guid(0x72ed066f, 0x70aa, 0x40c6, 0x9b, 0x1b, 0x34, 0x33, 0xf7, 0x45, 0x9b, 0x4e), ExclusiveTo(typeof(SimpleOrientationSensor)), Version(0x6020000)]
    internal interface ISimpleOrientationSensorStatics
    {
        SimpleOrientationSensor GetDefault();
    }
}

