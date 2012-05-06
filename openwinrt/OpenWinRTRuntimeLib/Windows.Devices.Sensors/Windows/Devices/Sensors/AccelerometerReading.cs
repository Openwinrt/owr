namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class AccelerometerReading : IAccelerometerReading
    {
        public double AccelerationX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double AccelerationY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double AccelerationZ { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Devices.Sensors.IAccelerometerReading.AccelerationX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Devices.Sensors.IAccelerometerReading.AccelerationY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Devices.Sensors.IAccelerometerReading.AccelerationZ { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Devices.Sensors.IAccelerometerReading.Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

