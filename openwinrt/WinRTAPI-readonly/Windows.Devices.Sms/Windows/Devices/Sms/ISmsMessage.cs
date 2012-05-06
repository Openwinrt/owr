namespace Windows.Devices.Sms
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xed3c5e28, 0x6984, 0x4b07, 0x81, 0x1d, 0x8d, 0x59, 6, 0xed, 60, 0xea)]
    public interface ISmsMessage
    {
        uint Id { get; }

        SmsMessageClass MessageClass { get; }
    }
}

