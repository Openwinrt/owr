namespace Windows.Devices.Sensors
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xc9c5c827, 0xc71c, 0x46e7, 0x9d, 0xa3, 0x36, 0xa1, 0x93, 0xb2, 50, 0xbc), ExclusiveTo(typeof(SensorQuaternion)), Version(0x6020000)]
    internal interface ISensorQuaternion
    {
        float W { get; }

        float X { get; }

        float Y { get; }

        float Z { get; }
    }
}

