namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(KeyDerivationAlgorithmProvider)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe1fba83b, 0x4671, 0x43b7, 0x91, 0x58, 0x76, 0x3a, 170, 0x98, 0xb6, 0xbf)]
    internal interface IKeyDerivationAlgorithmProvider
    {
        CryptographicKey CreateKey([In] IBuffer keyMaterial);

        string AlgorithmName { get; }
    }
}

