namespace Windows.Devices.Sms
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Activatable(0x6020000), DualApiPartition(version=0x6020000), Threading(ThreadingModel.Both), Static(typeof(ISmsTextMessageStatics), 0x6020000)]
    public sealed class SmsTextMessage : ISmsTextMessage, ISmsMessage
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SmsTextMessage();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static SmsTextMessage FromBinaryData([In] SmsDataFormat format, [In] byte[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static SmsTextMessage FromBinaryMessage([In] SmsBinaryMessage binaryMessage);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<ISmsBinaryMessage> ToBinaryMessages([In] SmsDataFormat format);

        public string Body { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public SmsEncoding Encoding { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string From { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SmsMessageClass MessageClass { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint PartCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint PartNumber { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint PartReferenceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string To { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Devices.Sms.ISmsMessage.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SmsMessageClass Windows.Devices.Sms.ISmsMessage.MessageClass { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Devices.Sms.ISmsTextMessage.Body { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public SmsEncoding Windows.Devices.Sms.ISmsTextMessage.Encoding { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Devices.Sms.ISmsTextMessage.From { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Devices.Sms.ISmsTextMessage.PartCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Devices.Sms.ISmsTextMessage.PartNumber { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Devices.Sms.ISmsTextMessage.PartReferenceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Devices.Sms.ISmsTextMessage.Timestamp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Devices.Sms.ISmsTextMessage.To { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

