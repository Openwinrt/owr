namespace Windows.Devices.Sensors
{
    using Windows.Foundation.Metadata;

    [Guid(0x10ef8712, 0xfb4c, 0x428a, 0x89, 0x8b, 0x27, 0x65, 0xe4, 9, 230, 0x69), Version(0x6020000), ExclusiveTo(typeof(OrientationSensor))]
    internal interface IOrientationSensorStatics
    {
        OrientationSensor GetDefault();
    }
}

