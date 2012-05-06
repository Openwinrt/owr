namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), DualApiPartition(version=0x6020000), Threading(ThreadingModel.Both), Static(typeof(ISymmetricKeyAlgorithmProviderStatics), 0x6020000)]
    public sealed class SymmetricKeyAlgorithmProvider : ISymmetricKeyAlgorithmProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CryptographicKey CreateSymmetricKey([In] IBuffer keyMaterial);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static SymmetricKeyAlgorithmProvider OpenAlgorithm([In] string algorithm);

        public string AlgorithmName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint BlockLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Cryptography.Core.ISymmetricKeyAlgorithmProvider.AlgorithmName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Security.Cryptography.Core.ISymmetricKeyAlgorithmProvider.BlockLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

