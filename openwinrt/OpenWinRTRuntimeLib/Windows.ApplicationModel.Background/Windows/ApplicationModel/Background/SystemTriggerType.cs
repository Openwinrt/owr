namespace Windows.ApplicationModel.Background
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum SystemTriggerType
    {
        Invalid,
        SessionStart,
        SmsReceived,
        UserPresent,
        UserAway,
        NetworkStateChange,
        NetworkControlChannelTriggerReset,
        InternetAvailable,
        InternetNotAvailable,
        SessionConnected,
        SessionDisconnected,
        ServicingComplete,
        LockScreenApplicationAdded,
        LockScreenApplicationRemoved,
        TimeZoneChange,
        OnlineIdConnectedStateChange
    }
}

