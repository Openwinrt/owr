namespace Windows.Devices.Sensors
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xb9fe7acb, 0xd351, 0x40af, 0x8b, 0xb6, 0x7a, 0xa9, 0xae, 100, 0x1f, 0xb7), ExclusiveTo(typeof(AccelerometerReading))]
    internal interface IAccelerometerReading
    {
        double AccelerationX { get; }

        double AccelerationY { get; }

        double AccelerationZ { get; }

        Windows.Foundation.DateTime Timestamp { get; }
    }
}

