namespace Windows.Devices.Sms
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x91791ed, 0x872b, 0x4eec, 0x9c, 0x72, 0xab, 0x11, 0x62, 0x7b, 0x34, 0xec), Version(0x6020000)]
    public interface ISmsDevice
    {
        event SmsDeviceStatusChangedEventHandler SmsDeviceStatusChanged;

        event SmsMessageReceivedEventHandler SmsMessageReceived;

        SmsEncodedLength CalculateLength([In] SmsTextMessage message);
        SendSmsMessageOperation SendMessageAsync([In] ISmsMessage message);

        string AccountPhoneNumber { get; }

        Windows.Devices.Sms.CellularClass CellularClass { get; }

        SmsDeviceStatus DeviceStatus { get; }

        SmsDeviceMessageStore MessageStore { get; }
    }
}

