namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SimpleOrientationSensor)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5ff53856, 0x214a, 0x4dee, 0xa3, 0xf9, 0x61, 0x6f, 0x1a, 0xb0, 0x6f, 0xfd)]
    internal interface ISimpleOrientationSensor
    {
        event TypedEventHandler<SimpleOrientationSensor, SimpleOrientationSensorOrientationChangedEventArgs> OrientationChanged;

        SimpleOrientation GetCurrentOrientation();
    }
}

