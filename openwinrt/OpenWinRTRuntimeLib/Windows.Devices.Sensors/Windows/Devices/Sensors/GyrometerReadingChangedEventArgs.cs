namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class GyrometerReadingChangedEventArgs : IGyrometerReadingChangedEventArgs
    {
        public GyrometerReading Reading { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public GyrometerReading Windows.Devices.Sensors.IGyrometerReadingChangedEventArgs.Reading { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

