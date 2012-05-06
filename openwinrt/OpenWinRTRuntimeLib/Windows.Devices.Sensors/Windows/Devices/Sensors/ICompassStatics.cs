namespace Windows.Devices.Sensors
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Compass)), Guid(0x9abc97df, 0x56ec, 0x4c25, 0xb5, 0x4d, 0x40, 0xa6, 0x8b, 0xb5, 0xb2, 0x69), Version(0x6020000)]
    internal interface ICompassStatics
    {
        Compass GetDefault();
    }
}

