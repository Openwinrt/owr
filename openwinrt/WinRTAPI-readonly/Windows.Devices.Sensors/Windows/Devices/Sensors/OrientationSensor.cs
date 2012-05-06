namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Static(typeof(IOrientationSensorStatics), 0x6020000), Version(0x6020000), Threading(ThreadingModel.MTA), DualApiPartition(version=0x6020000)]
    public sealed class OrientationSensor : IOrientationSensor
    {
        public event TypedEventHandler<OrientationSensor, OrientationSensorReadingChangedEventArgs> ReadingChanged;

        public event TypedEventHandler<OrientationSensor, OrientationSensorReadingChangedEventArgs> Windows.Devices.Sensors.IOrientationSensor.ReadingChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public OrientationSensorReading GetCurrentReading();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static OrientationSensor GetDefault();

        public uint MinimumReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint ReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Devices.Sensors.IOrientationSensor.MinimumReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Devices.Sensors.IOrientationSensor.ReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

