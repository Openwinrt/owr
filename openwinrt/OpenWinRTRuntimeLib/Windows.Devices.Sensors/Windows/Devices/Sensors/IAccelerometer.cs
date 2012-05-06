namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xdf184548, 0x2711, 0x4da7, 0x80, 0x98, 0x4b, 130, 0x20, 0x5d, 60, 0x7d), ExclusiveTo(typeof(Accelerometer)), Version(0x6020000)]
    internal interface IAccelerometer
    {
        event TypedEventHandler<Accelerometer, AccelerometerReadingChangedEventArgs> ReadingChanged;

        event TypedEventHandler<Accelerometer, AccelerometerShakenEventArgs> Shaken;

        AccelerometerReading GetCurrentReading();

        uint MinimumReportInterval { get; }

        uint ReportInterval { get; [param: In] set; }
    }
}

