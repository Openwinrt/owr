namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class OrientationSensorReading : IOrientationSensorReading
    {
        public SensorQuaternion Quaternion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SensorRotationMatrix RotationMatrix { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SensorQuaternion Windows.Devices.Sensors.IOrientationSensorReading.Quaternion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SensorRotationMatrix Windows.Devices.Sensors.IOrientationSensorReading.RotationMatrix { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Devices.Sensors.IOrientationSensorReading.Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

