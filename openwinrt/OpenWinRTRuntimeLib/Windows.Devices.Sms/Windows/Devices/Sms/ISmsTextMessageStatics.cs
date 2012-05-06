namespace Windows.Devices.Sms
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x7f68c5ed, 0x3ccc, 0x47a3, 140, 0x55, 0x38, 13, 0x3b, 1, 8, 0x92), ExclusiveTo(typeof(SmsTextMessage))]
    internal interface ISmsTextMessageStatics
    {
        SmsTextMessage FromBinaryData([In] SmsDataFormat format, [In] byte[] value);
        SmsTextMessage FromBinaryMessage([In] SmsBinaryMessage binaryMessage);
    }
}

