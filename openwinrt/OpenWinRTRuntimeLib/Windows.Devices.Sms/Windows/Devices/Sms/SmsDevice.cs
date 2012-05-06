namespace Windows.Devices.Sms
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Static(typeof(ISmsDeviceStatics), 0x6020000), DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class SmsDevice : ISmsDevice
    {
        public event SmsDeviceStatusChangedEventHandler SmsDeviceStatusChanged;

        public event SmsMessageReceivedEventHandler SmsMessageReceived;

        public event SmsDeviceStatusChangedEventHandler Windows.Devices.Sms.ISmsDevice.SmsDeviceStatusChanged;

        public event SmsMessageReceivedEventHandler Windows.Devices.Sms.ISmsDevice.SmsMessageReceived;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SmsEncodedLength CalculateLength([In] SmsTextMessage message);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<SmsDevice> FromIdAsync([In] string deviceInstanceId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<SmsDevice> GetDefaultAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetDeviceSelector();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SendSmsMessageOperation SendMessageAsync([In] ISmsMessage message);

        public string AccountPhoneNumber { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Sms.CellularClass CellularClass { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SmsDeviceStatus DeviceStatus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SmsDeviceMessageStore MessageStore { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Devices.Sms.ISmsDevice.AccountPhoneNumber { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Sms.CellularClass Windows.Devices.Sms.ISmsDevice.CellularClass { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SmsDeviceStatus Windows.Devices.Sms.ISmsDevice.DeviceStatus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SmsDeviceMessageStore Windows.Devices.Sms.ISmsDevice.MessageStore { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

