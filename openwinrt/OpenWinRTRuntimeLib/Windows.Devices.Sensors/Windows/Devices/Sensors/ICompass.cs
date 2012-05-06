namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Compass)), Windows.Foundation.Metadata.Guid(0x292ffa94, 0x1b45, 0x403c, 0xba, 6, 0xb1, 6, 0xdb, 0xa6, 0x9a, 100), Version(0x6020000)]
    internal interface ICompass
    {
        event TypedEventHandler<Compass, CompassReadingChangedEventArgs> ReadingChanged;

        CompassReading GetCurrentReading();

        uint MinimumReportInterval { get; }

        uint ReportInterval { get; [param: In] set; }
    }
}

