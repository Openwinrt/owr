namespace Windows.Devices.Sms
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000), Activatable(0x6020000)]
    public sealed class SmsBinaryMessage : ISmsBinaryMessage, ISmsMessage
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SmsBinaryMessage();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public byte[] GetData();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetData([In] byte[] value);

        public SmsDataFormat Format { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SmsMessageClass MessageClass { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SmsDataFormat Windows.Devices.Sms.ISmsBinaryMessage.Format { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Devices.Sms.ISmsMessage.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SmsMessageClass Windows.Devices.Sms.ISmsMessage.MessageClass { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

