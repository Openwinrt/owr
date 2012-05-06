namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class SensorQuaternion : ISensorQuaternion
    {
        public float W { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.Devices.Sensors.ISensorQuaternion.W { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.Devices.Sensors.ISensorQuaternion.X { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.Devices.Sensors.ISensorQuaternion.Y { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.Devices.Sensors.ISensorQuaternion.Z { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float X { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Y { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Z { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

