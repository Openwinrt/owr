namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class OrientationSensorReadingChangedEventArgs : IOrientationSensorReadingChangedEventArgs
    {
        public OrientationSensorReading Reading { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public OrientationSensorReading Windows.Devices.Sensors.IOrientationSensorReadingChangedEventArgs.Reading { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

