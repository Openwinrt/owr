namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class CompassReading : ICompassReading
    {
        public double HeadingMagneticNorth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<double> HeadingTrueNorth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Devices.Sensors.ICompassReading.HeadingMagneticNorth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<double> Windows.Devices.Sensors.ICompassReading.HeadingTrueNorth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Devices.Sensors.ICompassReading.Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

