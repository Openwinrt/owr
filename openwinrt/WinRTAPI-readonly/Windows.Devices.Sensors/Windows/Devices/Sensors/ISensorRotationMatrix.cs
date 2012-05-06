namespace Windows.Devices.Sensors
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xa3d5a67, 0x22f4, 0x4392, 0x95, 0x38, 0x65, 0xd0, 0xbd, 6, 0x4a, 0xa6), ExclusiveTo(typeof(SensorRotationMatrix)), Version(0x6020000)]
    internal interface ISensorRotationMatrix
    {
        float M11 { get; }

        float M12 { get; }

        float M13 { get; }

        float M21 { get; }

        float M22 { get; }

        float M23 { get; }

        float M31 { get; }

        float M32 { get; }

        float M33 { get; }
    }
}

