namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Static(typeof(IInclinometerStatics), 0x6020000), Version(0x6020000), Threading(ThreadingModel.MTA)]
    public sealed class Inclinometer : IInclinometer
    {
        public event TypedEventHandler<Inclinometer, InclinometerReadingChangedEventArgs> ReadingChanged;

        public event TypedEventHandler<Inclinometer, InclinometerReadingChangedEventArgs> Windows.Devices.Sensors.IInclinometer.ReadingChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public InclinometerReading GetCurrentReading();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Inclinometer GetDefault();

        public uint MinimumReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint ReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Devices.Sensors.IInclinometer.MinimumReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Devices.Sensors.IInclinometer.ReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

