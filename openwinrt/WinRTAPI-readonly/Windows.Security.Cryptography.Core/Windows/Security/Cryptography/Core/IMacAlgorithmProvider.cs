namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Windows.Foundation.Metadata.Guid(0x4a3fc5c3, 0x1cbd, 0x41ce, 160, 0x92, 170, 11, 0xc5, 210, 210, 0xf5), ExclusiveTo(typeof(MacAlgorithmProvider)), Version(0x6020000)]
    internal interface IMacAlgorithmProvider
    {
        CryptographicKey CreateKey([In] IBuffer keyMaterial);

        string AlgorithmName { get; }

        uint MacLength { get; }
    }
}

