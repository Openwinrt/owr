namespace Windows.Devices.Sensors
{
    using Windows.Foundation.Metadata;

    [Guid(0xa5e28b74, 0x5a87, 0x4a2d, 190, 0xcc, 15, 0x90, 110, 160, 0x61, 0xdd), Version(0x6020000), ExclusiveTo(typeof(Accelerometer))]
    internal interface IAccelerometerStatics
    {
        Accelerometer GetDefault();
    }
}

