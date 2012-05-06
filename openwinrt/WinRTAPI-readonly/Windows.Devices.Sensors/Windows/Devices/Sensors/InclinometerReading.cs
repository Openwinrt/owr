namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class InclinometerReading : IInclinometerReading
    {
        public float PitchDegrees { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float RollDegrees { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.Devices.Sensors.IInclinometerReading.PitchDegrees { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.Devices.Sensors.IInclinometerReading.RollDegrees { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Devices.Sensors.IInclinometerReading.Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.Devices.Sensors.IInclinometerReading.YawDegrees { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float YawDegrees { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

