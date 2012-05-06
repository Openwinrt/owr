namespace Windows.Devices.Sensors
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0x82911128, 0x513d, 0x4dc9, 0xb7, 0x81, 0x5e, 0xed, 0xfb, 240, 0x2d, 12), Version(0x6020000), ExclusiveTo(typeof(CompassReading))]
    internal interface ICompassReading
    {
        double HeadingMagneticNorth { get; }

        IReference<double> HeadingTrueNorth { get; }

        Windows.Foundation.DateTime Timestamp { get; }
    }
}

