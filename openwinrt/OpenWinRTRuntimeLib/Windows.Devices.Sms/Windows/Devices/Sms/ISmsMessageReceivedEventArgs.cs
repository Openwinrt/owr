namespace Windows.Devices.Sms
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x8e80a98, 0xb8e5, 0x41c1, 0xa3, 0xd8, 0xd3, 0xab, 250, 0xe2, 0x26, 0x75), ExclusiveTo(typeof(SmsMessageReceivedEventArgs))]
    internal interface ISmsMessageReceivedEventArgs
    {
        SmsBinaryMessage BinaryMessage { get; }

        SmsTextMessage TextMessage { get; }
    }
}

