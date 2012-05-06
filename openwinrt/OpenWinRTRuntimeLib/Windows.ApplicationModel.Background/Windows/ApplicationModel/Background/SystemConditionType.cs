namespace Windows.ApplicationModel.Background
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum SystemConditionType
    {
        Invalid,
        UserPresent,
        UserNotPresent,
        InternetAvailable,
        InternetNotAvailable,
        SessionConnected,
        SessionDisconnected
    }
}

