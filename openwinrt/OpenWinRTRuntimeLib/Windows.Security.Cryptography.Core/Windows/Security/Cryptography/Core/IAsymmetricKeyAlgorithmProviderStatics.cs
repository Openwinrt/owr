namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x425bde18, 0xa7f3, 0x47a6, 0xa8, 210, 0xc4, 0x8d, 0x60, 0x33, 0xa6, 0x5c), Version(0x6020000), ExclusiveTo(typeof(AsymmetricKeyAlgorithmProvider))]
    internal interface IAsymmetricKeyAlgorithmProviderStatics
    {
        AsymmetricKeyAlgorithmProvider OpenAlgorithm([In] string algorithm);
    }
}

