namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Windows.Foundation.Metadata.Guid(0x3d7e4a33, 0x3bd0, 0x4902, 0x8a, 200, 0x47, 13, 80, 210, 0x13, 0x76), ExclusiveTo(typeof(SymmetricKeyAlgorithmProvider)), Version(0x6020000)]
    internal interface ISymmetricKeyAlgorithmProvider
    {
        CryptographicKey CreateSymmetricKey([In] IBuffer keyMaterial);

        string AlgorithmName { get; }

        uint BlockLength { get; }
    }
}

