namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class InclinometerReadingChangedEventArgs : IInclinometerReadingChangedEventArgs
    {
        public InclinometerReading Reading { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public InclinometerReading Windows.Devices.Sensors.IInclinometerReadingChangedEventArgs.Reading { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

