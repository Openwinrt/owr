namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x2648ca6f, 0x2286, 0x406f, 0x91, 0x61, 240, 0xc4, 0xbd, 0x80, 110, 0xbf), ExclusiveTo(typeof(Inclinometer))]
    internal interface IInclinometer
    {
        event TypedEventHandler<Inclinometer, InclinometerReadingChangedEventArgs> ReadingChanged;

        InclinometerReading GetCurrentReading();

        uint MinimumReportInterval { get; }

        uint ReportInterval { get; [param: In] set; }
    }
}

