namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [MarshalingBehavior(MarshalingType.FreeThreaded), DualApiPartition(version=0x6020000), Static(typeof(IMacAlgorithmProviderStatics), 0x6020000), Threading(ThreadingModel.Both), Version(0x6020000)]
    public sealed class MacAlgorithmProvider : IMacAlgorithmProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CryptographicKey CreateKey([In] IBuffer keyMaterial);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static MacAlgorithmProvider OpenAlgorithm([In] string algorithm);

        public string AlgorithmName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint MacLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Cryptography.Core.IMacAlgorithmProvider.AlgorithmName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Security.Cryptography.Core.IMacAlgorithmProvider.MacLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

