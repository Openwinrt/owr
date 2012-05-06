namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class CompassReadingChangedEventArgs : ICompassReadingChangedEventArgs
    {
        public CompassReading Reading { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CompassReading Windows.Devices.Sensors.ICompassReadingChangedEventArgs.Reading { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

