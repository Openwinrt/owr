namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Threading(ThreadingModel.Both), DualApiPartition(version=0x6020000), Version(0x6020000), Static(typeof(IKeyDerivationAlgorithmProviderStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class KeyDerivationAlgorithmProvider : IKeyDerivationAlgorithmProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CryptographicKey CreateKey([In] IBuffer keyMaterial);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static KeyDerivationAlgorithmProvider OpenAlgorithm([In] string algorithm);

        public string AlgorithmName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Cryptography.Core.IKeyDerivationAlgorithmProvider.AlgorithmName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

