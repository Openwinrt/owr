namespace Windows.Devices.Sms
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum SmsDeviceStatus
    {
        Off,
        Ready,
        SimNotInserted,
        BadSim,
        DeviceFailure,
        SubscriptionNotActivated,
        DeviceLocked,
        DeviceBlocked
    }
}

