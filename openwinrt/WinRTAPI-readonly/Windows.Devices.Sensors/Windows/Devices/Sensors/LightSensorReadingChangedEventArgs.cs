namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class LightSensorReadingChangedEventArgs : ILightSensorReadingChangedEventArgs
    {
        public LightSensorReading Reading { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LightSensorReading Windows.Devices.Sensors.ILightSensorReadingChangedEventArgs.Reading { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

