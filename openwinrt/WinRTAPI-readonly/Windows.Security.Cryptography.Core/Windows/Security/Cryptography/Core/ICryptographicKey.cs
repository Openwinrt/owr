namespace Windows.Security.Cryptography.Core
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), Guid(0xed2a3b70, 0x8e7b, 0x4009, 0x84, 1, 0xff, 0xd1, 0xa6, 0x2e, 0xeb, 0x27), ExclusiveTo(typeof(CryptographicKey))]
    internal interface ICryptographicKey
    {
        IBuffer Export();
        IBuffer ExportPublicKey();

        uint KeySize { get; }
    }
}

