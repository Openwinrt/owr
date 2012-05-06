namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class LightSensorReading : ILightSensorReading
    {
        public float IlluminanceInLux { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.Devices.Sensors.ILightSensorReading.IlluminanceInLux { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Devices.Sensors.ILightSensorReading.Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

