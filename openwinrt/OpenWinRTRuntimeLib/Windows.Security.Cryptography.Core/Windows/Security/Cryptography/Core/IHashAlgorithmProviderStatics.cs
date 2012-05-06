namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(HashAlgorithmProvider)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x9fac9741, 0x5cc4, 0x4336, 0xae, 0x38, 0x62, 0x12, 0xb7, 90, 0x91, 90)]
    internal interface IHashAlgorithmProviderStatics
    {
        HashAlgorithmProvider OpenAlgorithm([In] string algorithm);
    }
}

