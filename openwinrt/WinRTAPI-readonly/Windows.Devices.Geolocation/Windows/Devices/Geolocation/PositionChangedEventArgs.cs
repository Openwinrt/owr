namespace Windows.Devices.Geolocation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class PositionChangedEventArgs : IPositionChangedEventArgs
    {
        public Geoposition Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Geoposition Windows.Devices.Geolocation.IPositionChangedEventArgs.Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

