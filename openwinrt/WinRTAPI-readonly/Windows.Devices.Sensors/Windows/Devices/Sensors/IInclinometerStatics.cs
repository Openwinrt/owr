namespace Windows.Devices.Sensors
{
    using Windows.Foundation.Metadata;

    [Guid(0xf22ec551, 0x9c30, 0x453a, 0x8b, 0x49, 60, 0x3e, 0xeb, 0x33, 0xcb, 0x61), ExclusiveTo(typeof(Inclinometer)), Version(0x6020000)]
    internal interface IInclinometerStatics
    {
        Inclinometer GetDefault();
    }
}

