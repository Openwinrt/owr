namespace Windows.Devices.Sensors
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x95ff01d1, 0x4a28, 0x4f35, 0x98, 0xe8, 0x81, 120, 170, 0xe4, 8, 0x4a), ExclusiveTo(typeof(AccelerometerShakenEventArgs))]
    internal interface IAccelerometerShakenEventArgs
    {
        DateTime Timestamp { get; }
    }
}

