namespace Windows.Devices.Geolocation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Geolocator)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa9c3bf62, 0x4524, 0x4989, 0x8a, 0xa9, 0xde, 1, 0x9d, 0x2e, 0x55, 0x1f)]
    internal interface IGeolocator
    {
        event TypedEventHandler<Geolocator, PositionChangedEventArgs> PositionChanged;

        event TypedEventHandler<Geolocator, StatusChangedEventArgs> StatusChanged;

        IAsyncOperation<Geoposition> GetGeopositionAsync();

        PositionAccuracy DesiredAccuracy { get; [param: In] set; }

        PositionStatus LocationStatus { get; }

        double MovementThreshold { get; [param: In] set; }

        uint ReportInterval { get; [param: In] set; }
    }
}

