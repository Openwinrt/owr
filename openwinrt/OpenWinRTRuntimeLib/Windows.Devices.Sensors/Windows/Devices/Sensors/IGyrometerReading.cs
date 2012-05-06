namespace Windows.Devices.Sensors
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(GyrometerReading)), Guid(0xb3d6de5c, 0x1ee4, 0x456f, 0x9d, 0xe7, 0xe2, 0x49, 0x3b, 0x5c, 0x8e, 3)]
    internal interface IGyrometerReading
    {
        double AngularVelocityX { get; }

        double AngularVelocityY { get; }

        double AngularVelocityZ { get; }

        Windows.Foundation.DateTime Timestamp { get; }
    }
}

