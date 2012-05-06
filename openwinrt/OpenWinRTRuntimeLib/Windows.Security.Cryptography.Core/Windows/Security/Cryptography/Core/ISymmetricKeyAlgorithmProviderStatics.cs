namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x8d3b2326, 0x1f37, 0x491f, 0xb6, 14, 0xf5, 0x43, 0x1b, 0x26, 180, 0x83), Version(0x6020000), ExclusiveTo(typeof(SymmetricKeyAlgorithmProvider))]
    internal interface ISymmetricKeyAlgorithmProviderStatics
    {
        SymmetricKeyAlgorithmProvider OpenAlgorithm([In] string algorithm);
    }
}

