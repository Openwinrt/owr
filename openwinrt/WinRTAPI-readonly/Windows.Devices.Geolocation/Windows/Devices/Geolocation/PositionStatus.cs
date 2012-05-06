namespace Windows.Devices.Geolocation
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum PositionStatus
    {
        Ready,
        Initializing,
        NoData,
        Disabled,
        NotInitialized,
        NotAvailable
    }
}

