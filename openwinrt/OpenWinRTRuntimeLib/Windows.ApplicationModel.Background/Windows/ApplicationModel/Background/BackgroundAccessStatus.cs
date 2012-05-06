namespace Windows.ApplicationModel.Background
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum BackgroundAccessStatus
    {
        Unspecified,
        AllowedWithRealTimeConnectivity,
        AllowedWithoutRealTimeConnectivity,
        Denied
    }
}

