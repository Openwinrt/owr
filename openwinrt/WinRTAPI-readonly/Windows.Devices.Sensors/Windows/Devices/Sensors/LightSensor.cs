namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.MTA), DualApiPartition(version=0x6020000), Version(0x6020000), Static(typeof(ILightSensorStatics), 0x6020000)]
    public sealed class LightSensor : ILightSensor
    {
        public event TypedEventHandler<LightSensor, LightSensorReadingChangedEventArgs> ReadingChanged;

        public event TypedEventHandler<LightSensor, LightSensorReadingChangedEventArgs> Windows.Devices.Sensors.ILightSensor.ReadingChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public LightSensorReading GetCurrentReading();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static LightSensor GetDefault();

        public uint MinimumReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint ReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Devices.Sensors.ILightSensor.MinimumReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Devices.Sensors.ILightSensor.ReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

