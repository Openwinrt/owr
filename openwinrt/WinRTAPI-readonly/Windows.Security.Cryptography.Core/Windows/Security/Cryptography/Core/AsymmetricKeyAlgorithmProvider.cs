namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), DualApiPartition(version=0x6020000), Static(typeof(IAsymmetricKeyAlgorithmProviderStatics), 0x6020000)]
    public sealed class AsymmetricKeyAlgorithmProvider : IAsymmetricKeyAlgorithmProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CryptographicKey CreateKeyPair([In] uint keySize);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CryptographicKey ImportKeyPair([In] IBuffer keyBlob);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CryptographicKey ImportPublicKey([In] IBuffer keyBlob);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static AsymmetricKeyAlgorithmProvider OpenAlgorithm([In] string algorithm);

        public string AlgorithmName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Cryptography.Core.IAsymmetricKeyAlgorithmProvider.AlgorithmName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

