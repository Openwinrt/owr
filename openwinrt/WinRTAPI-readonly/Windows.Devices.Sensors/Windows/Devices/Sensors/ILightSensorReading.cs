namespace Windows.Devices.Sensors
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(LightSensorReading)), Version(0x6020000), Guid(0xffdf6300, 0x227c, 0x4d2b, 0xb3, 2, 0xfc, 1, 0x42, 0x48, 0x5c, 0x68)]
    internal interface ILightSensorReading
    {
        float IlluminanceInLux { get; }

        Windows.Foundation.DateTime Timestamp { get; }
    }
}

