namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class CryptographicKey : ICryptographicKey
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IBuffer Export();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IBuffer ExportPublicKey();

        public uint KeySize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Security.Cryptography.Core.ICryptographicKey.KeySize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

