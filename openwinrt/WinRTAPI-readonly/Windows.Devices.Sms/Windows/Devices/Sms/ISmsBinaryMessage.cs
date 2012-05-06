namespace Windows.Devices.Sms
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5bf4e813, 0x3b53, 0x4c6e, 0xb6, 0x1a, 0xd8, 0x6a, 0x63, 0x75, 0x56, 80)]
    public interface ISmsBinaryMessage : ISmsMessage
    {
        byte[] GetData();
        void SetData([In] byte[] value);

        SmsDataFormat Format { get; [param: In] set; }
    }
}

