namespace Windows.Security.Cryptography.DataProtection
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Activatable(typeof(IDataProtectionProviderFactory), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), DualApiPartition(version=0x6020000), Version(0x6020000), Activatable(0x6020000)]
    public sealed class DataProtectionProvider : IDataProtectionProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataProtectionProvider();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataProtectionProvider([In] string protectionDescriptor);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IBuffer> ProtectAsync([In] IBuffer data);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction ProtectStreamAsync([In] IInputStream src, [In] IOutputStream dest);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IBuffer> UnprotectAsync([In] IBuffer data);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction UnprotectStreamAsync([In] IInputStream src, [In] IOutputStream dest);
    }
}

