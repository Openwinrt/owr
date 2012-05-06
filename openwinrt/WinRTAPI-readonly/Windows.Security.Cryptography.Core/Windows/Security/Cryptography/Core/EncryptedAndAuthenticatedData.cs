namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [DualApiPartition(version=0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class EncryptedAndAuthenticatedData : IEncryptedAndAuthenticatedData
    {
        public IBuffer AuthenticationTag { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IBuffer EncryptedData { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IBuffer Windows.Security.Cryptography.Core.IEncryptedAndAuthenticatedData.AuthenticationTag { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IBuffer Windows.Security.Cryptography.Core.IEncryptedAndAuthenticatedData.EncryptedData { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

