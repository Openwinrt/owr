namespace Windows.Devices.Sensors
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Gyrometer)), Version(0x6020000), Guid(0x83b6e7c9, 0xe49d, 0x4b39, 0x86, 230, 0xcd, 0x55, 0x4b, 0xe4, 0xc5, 0xc1)]
    internal interface IGyrometerStatics
    {
        Gyrometer GetDefault();
    }
}

