namespace Windows.Devices.Sms
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SmsDeviceMessageStore)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x9889f253, 0xf188, 0x4427, 0x8d, 0x54, 0xce, 12, 0x24, 0x23, 0xc5, 0xc1)]
    internal interface ISmsDeviceMessageStore
    {
        IAsyncAction DeleteMessageAsync([In] uint messageId);
        IAsyncAction DeleteMessagesAsync([In] SmsMessageFilter messageFilter);
        IAsyncOperation<ISmsMessage> GetMessageAsync([In] uint messageId);
        IAsyncOperationWithProgress<IVectorView<ISmsMessage>, int> GetMessagesAsync([In] SmsMessageFilter messageFilter);

        uint MaxMessages { get; }
    }
}

