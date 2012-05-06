namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class AccelerometerReadingChangedEventArgs : IAccelerometerReadingChangedEventArgs
    {
        public AccelerometerReading Reading { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public AccelerometerReading Windows.Devices.Sensors.IAccelerometerReadingChangedEventArgs.Reading { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

