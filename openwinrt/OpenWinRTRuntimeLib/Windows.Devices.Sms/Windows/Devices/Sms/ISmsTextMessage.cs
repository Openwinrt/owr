namespace Windows.Devices.Sms
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xd61c904c, 0xa495, 0x487f, 0x9a, 0x6f, 0x97, 0x15, 0x48, 0xc5, 0xbc, 0x9f), Version(0x6020000)]
    public interface ISmsTextMessage : ISmsMessage
    {
        IVectorView<ISmsBinaryMessage> ToBinaryMessages([In] SmsDataFormat format);

        string Body { get; [param: In] set; }

        SmsEncoding Encoding { get; [param: In] set; }

        string From { get; [param: In] set; }

        uint PartCount { get; }

        uint PartNumber { get; }

        uint PartReferenceId { get; }

        Windows.Foundation.DateTime Timestamp { get; }

        string To { get; [param: In] set; }
    }
}

