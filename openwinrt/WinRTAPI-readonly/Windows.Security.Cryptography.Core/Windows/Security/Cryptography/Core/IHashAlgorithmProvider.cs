namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), ExclusiveTo(typeof(HashAlgorithmProvider)), Windows.Foundation.Metadata.Guid(0xbe9b3080, 0xb2c3, 0x422b, 0xbc, 0xe1, 0xec, 0x90, 0xef, 0xb5, 0xd7, 0xb5)]
    internal interface IHashAlgorithmProvider
    {
        CryptographicHash CreateHash();
        IBuffer HashData([In] IBuffer data);

        string AlgorithmName { get; }

        uint HashLength { get; }
    }
}

