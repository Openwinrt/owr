namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xf84c0718, 0xc54, 0x47ae, 0x92, 0x2e, 120, 0x9f, 0x57, 0xfb, 3, 160), ExclusiveTo(typeof(LightSensor)), Version(0x6020000)]
    internal interface ILightSensor
    {
        event TypedEventHandler<LightSensor, LightSensorReadingChangedEventArgs> ReadingChanged;

        LightSensorReading GetCurrentReading();

        uint MinimumReportInterval { get; }

        uint ReportInterval { get; [param: In] set; }
    }
}

