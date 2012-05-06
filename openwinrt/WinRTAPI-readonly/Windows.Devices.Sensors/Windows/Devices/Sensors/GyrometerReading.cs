namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class GyrometerReading : IGyrometerReading
    {
        public double AngularVelocityX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double AngularVelocityY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double AngularVelocityZ { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Devices.Sensors.IGyrometerReading.AngularVelocityX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Devices.Sensors.IGyrometerReading.AngularVelocityY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Devices.Sensors.IGyrometerReading.AngularVelocityZ { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Devices.Sensors.IGyrometerReading.Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

