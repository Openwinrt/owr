namespace Windows.Devices.Geolocation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Threading(ThreadingModel.MTA), MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000)]
    public sealed class Geolocator : IGeolocator
    {
        public event TypedEventHandler<Geolocator, PositionChangedEventArgs> PositionChanged;

        public event TypedEventHandler<Geolocator, StatusChangedEventArgs> StatusChanged;

        public event TypedEventHandler<Geolocator, PositionChangedEventArgs> Windows.Devices.Geolocation.IGeolocator.PositionChanged;

        public event TypedEventHandler<Geolocator, StatusChangedEventArgs> Windows.Devices.Geolocation.IGeolocator.StatusChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Geolocator();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<Geoposition> GetGeopositionAsync();

        public PositionAccuracy DesiredAccuracy { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PositionStatus LocationStatus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double MovementThreshold { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint ReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PositionAccuracy Windows.Devices.Geolocation.IGeolocator.DesiredAccuracy { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PositionStatus Windows.Devices.Geolocation.IGeolocator.LocationStatus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Devices.Geolocation.IGeolocator.MovementThreshold { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Devices.Geolocation.IGeolocator.ReportInterval { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

