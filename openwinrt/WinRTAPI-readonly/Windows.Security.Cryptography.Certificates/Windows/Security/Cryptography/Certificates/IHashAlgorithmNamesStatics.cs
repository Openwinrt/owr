namespace Windows.Security.Cryptography.Certificates
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x6b5e0516, 0xde96, 0x4f0a, 0x8d, 0x57, 220, 0xc9, 0xda, 0xe3, 0x6c, 0x76), Version(0x8000000), ExclusiveTo(typeof(HashAlgorithmNames))]
    internal interface IHashAlgorithmNamesStatics
    {
        string Sha1 { get; }

        string Sha256 { get; }

        string Sha384 { get; }

        string Sha512 { get; }
    }
}

