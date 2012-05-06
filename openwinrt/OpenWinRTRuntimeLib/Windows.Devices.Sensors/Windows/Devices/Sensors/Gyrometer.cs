namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(IGyrometerStatics), 0x6020000), Threading(ThreadingModel.MTA), DualApiPartition(version=0x6020000)]
    public sealed class Gyrometer : IGyrometer
    {
        public event TypedEventHandler<Gyrometer, GyrometerReadingChangedEventArgs> ReadingChanged;

        public event TypedEventHandler<Gyrometer, GyrometerReadingChangedEventArgs> Windows.Devices.Sensors.IGyrometer.ReadingChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GyrometerReading GetCurrentReading();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Gyrometer GetDefault();

        public uint MinimumReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint ReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Devices.Sensors.IGyrometer.MinimumReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Devices.Sensors.IGyrometer.ReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

