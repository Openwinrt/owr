namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.MTA), Version(0x6020000), DualApiPartition(version=0x6020000), Static(typeof(ISimpleOrientationSensorStatics), 0x6020000)]
    public sealed class SimpleOrientationSensor : ISimpleOrientationSensor
    {
        public event TypedEventHandler<SimpleOrientationSensor, SimpleOrientationSensorOrientationChangedEventArgs> OrientationChanged;

        public event TypedEventHandler<SimpleOrientationSensor, SimpleOrientationSensorOrientationChangedEventArgs> Windows.Devices.Sensors.ISimpleOrientationSensor.OrientationChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SimpleOrientation GetCurrentOrientation();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static SimpleOrientationSensor GetDefault();
    }
}

