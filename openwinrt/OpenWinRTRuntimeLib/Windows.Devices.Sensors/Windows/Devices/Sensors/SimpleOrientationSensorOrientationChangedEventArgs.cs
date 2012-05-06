namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class SimpleOrientationSensorOrientationChangedEventArgs : ISimpleOrientationSensorOrientationChangedEventArgs
    {
        public SimpleOrientation Orientation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SimpleOrientation Windows.Devices.Sensors.ISimpleOrientationSensorOrientationChangedEventArgs.Orientation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Devices.Sensors.ISimpleOrientationSensorOrientationChangedEventArgs.Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

