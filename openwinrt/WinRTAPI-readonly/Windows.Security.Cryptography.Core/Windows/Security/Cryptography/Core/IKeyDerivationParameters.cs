namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(KeyDerivationParameters)), Windows.Foundation.Metadata.Guid(0x7bf05967, 0x47b, 0x4a8c, 150, 0x4a, 70, 0x9f, 0xfd, 0x55, 0x22, 0xe2), Version(0x6020000)]
    internal interface IKeyDerivationParameters
    {
        uint IterationCount { get; }

        IBuffer KdfGenericBinary { get; [param: In] set; }
    }
}

