namespace Windows.Devices.Sensors
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000), Static(typeof(ICompassStatics), 0x6020000), Threading(ThreadingModel.MTA)]
    public sealed class Compass : ICompass
    {
        public event TypedEventHandler<Compass, CompassReadingChangedEventArgs> ReadingChanged;

        public event TypedEventHandler<Compass, CompassReadingChangedEventArgs> Windows.Devices.Sensors.ICompass.ReadingChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CompassReading GetCurrentReading();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Compass GetDefault();

        public uint MinimumReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint ReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Devices.Sensors.ICompass.MinimumReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Devices.Sensors.ICompass.ReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

