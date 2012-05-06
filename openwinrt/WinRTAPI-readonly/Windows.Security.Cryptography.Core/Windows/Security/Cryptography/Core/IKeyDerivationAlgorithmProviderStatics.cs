namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa22097a, 0xa1c, 0x443b, 0x94, 0x18, 0xb9, 0x49, 0x8a, 0xeb, 0x16, 3), ExclusiveTo(typeof(KeyDerivationAlgorithmProvider))]
    internal interface IKeyDerivationAlgorithmProviderStatics
    {
        KeyDerivationAlgorithmProvider OpenAlgorithm([In] string algorithm);
    }
}

