namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Static(typeof(IHashAlgorithmProviderStatics), 0x6020000), Threading(ThreadingModel.Both), DualApiPartition(version=0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class HashAlgorithmProvider : IHashAlgorithmProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CryptographicHash CreateHash();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IBuffer HashData([In] IBuffer data);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static HashAlgorithmProvider OpenAlgorithm([In] string algorithm);

        public string AlgorithmName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint HashLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Cryptography.Core.IHashAlgorithmProvider.AlgorithmName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Security.Cryptography.Core.IHashAlgorithmProvider.HashLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

