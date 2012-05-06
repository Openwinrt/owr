namespace Windows.Devices.Sms
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class SmsDeviceMessageStore : ISmsDeviceMessageStore
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction DeleteMessageAsync([In] uint messageId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction DeleteMessagesAsync([In] SmsMessageFilter messageFilter);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<ISmsMessage> GetMessageAsync([In] uint messageId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<IVectorView<ISmsMessage>, int> GetMessagesAsync([In] SmsMessageFilter messageFilter);

        public uint MaxMessages { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Devices.Sms.ISmsDeviceMessageStore.MaxMessages { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

