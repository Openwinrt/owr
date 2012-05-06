namespace Windows.Devices.Sensors
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x45db8c84, 0xc3a8, 0x471e, 0x9a, 0x53, 100, 0x57, 250, 0xd8, 0x7c, 14), ExclusiveTo(typeof(LightSensor))]
    internal interface ILightSensorStatics
    {
        LightSensor GetDefault();
    }
}

