namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class SensorRotationMatrix : ISensorRotationMatrix
    {
        public float M11 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float M12 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float M13 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float M21 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float M22 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float M23 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float M31 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float M32 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float M33 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.Devices.Sensors.ISensorRotationMatrix.M11 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.Devices.Sensors.ISensorRotationMatrix.M12 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.Devices.Sensors.ISensorRotationMatrix.M13 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.Devices.Sensors.ISensorRotationMatrix.M21 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.Devices.Sensors.ISensorRotationMatrix.M22 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.Devices.Sensors.ISensorRotationMatrix.M23 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.Devices.Sensors.ISensorRotationMatrix.M31 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.Devices.Sensors.ISensorRotationMatrix.M32 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.Devices.Sensors.ISensorRotationMatrix.M33 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

