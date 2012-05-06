namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Static(typeof(IAccelerometerStatics), 0x6020000), Threading(ThreadingModel.MTA), DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class Accelerometer : IAccelerometer
    {
        public event TypedEventHandler<Accelerometer, AccelerometerReadingChangedEventArgs> ReadingChanged;

        public event TypedEventHandler<Accelerometer, AccelerometerShakenEventArgs> Shaken;

        public event TypedEventHandler<Accelerometer, AccelerometerReadingChangedEventArgs> Windows.Devices.Sensors.IAccelerometer.ReadingChanged;

        public event TypedEventHandler<Accelerometer, AccelerometerShakenEventArgs> Windows.Devices.Sensors.IAccelerometer.Shaken;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public AccelerometerReading GetCurrentReading();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Accelerometer GetDefault();

        public uint MinimumReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint ReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Devices.Sensors.IAccelerometer.MinimumReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Devices.Sensors.IAccelerometer.ReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

