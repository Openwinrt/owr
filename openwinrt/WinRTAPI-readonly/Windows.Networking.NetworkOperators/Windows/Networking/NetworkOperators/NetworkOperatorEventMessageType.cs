namespace Windows.Networking.NetworkOperators
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum NetworkOperatorEventMessageType
    {
        Gsm,
        Cdma,
        Ussd,
        DataPlanThresholdReached,
        DataPlanReset,
        DataPlanDeleted,
        ProfileConnected,
        ProfileDisconnected,
        RegisteredRoaming,
        RegisteredHome
    }
}

