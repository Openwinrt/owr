namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Windows.Foundation.Metadata.Guid(0xe8d2ff37, 0x6259, 0x4e88, 0xb7, 0xe0, 0x94, 0x19, 0x1f, 0xde, 0x69, 0x9e), Version(0x6020000), ExclusiveTo(typeof(AsymmetricKeyAlgorithmProvider))]
    internal interface IAsymmetricKeyAlgorithmProvider
    {
        CryptographicKey CreateKeyPair([In] uint keySize);
        CryptographicKey ImportKeyPair([In] IBuffer keyBlob);
        CryptographicKey ImportPublicKey([In] IBuffer keyBlob);

        string AlgorithmName { get; }
    }
}

