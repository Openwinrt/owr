namespace Windows.Devices.Geolocation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class StatusChangedEventArgs : IStatusChangedEventArgs
    {
        public PositionStatus Status { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PositionStatus Windows.Devices.Geolocation.IStatusChangedEventArgs.Status { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

