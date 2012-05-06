namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5e354635, 0xcf6b, 0x4c63, 0xab, 0xd8, 0x10, 0x25, 0x2b, 11, 0xf6, 0xec), ExclusiveTo(typeof(OrientationSensor))]
    internal interface IOrientationSensor
    {
        event TypedEventHandler<OrientationSensor, OrientationSensorReadingChangedEventArgs> ReadingChanged;

        OrientationSensorReading GetCurrentReading();

        uint MinimumReportInterval { get; }

        uint ReportInterval { get; [param: In] set; }
    }
}

