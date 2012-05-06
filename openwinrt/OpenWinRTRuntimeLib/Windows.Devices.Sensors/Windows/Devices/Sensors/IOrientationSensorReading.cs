namespace Windows.Devices.Sensors
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0x4756c993, 0x6595, 0x4897, 0xbc, 0xc6, 0xd5, 0x37, 0xee, 0x75, 0x75, 100), ExclusiveTo(typeof(OrientationSensorReading)), Version(0x6020000)]
    internal interface IOrientationSensorReading
    {
        SensorQuaternion Quaternion { get; }

        SensorRotationMatrix RotationMatrix { get; }

        DateTime Timestamp { get; }
    }
}

