namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xfdb9a9c4, 0x84b1, 0x4ca2, 0x97, 0x63, 0x9b, 0x58, 0x95, 6, 0xc7, 12), ExclusiveTo(typeof(Gyrometer)), Version(0x6020000)]
    internal interface IGyrometer
    {
        event TypedEventHandler<Gyrometer, GyrometerReadingChangedEventArgs> ReadingChanged;

        GyrometerReading GetCurrentReading();

        uint MinimumReportInterval { get; }

        uint ReportInterval { get; [param: In] set; }
    }
}

