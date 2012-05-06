namespace Windows.Security.Cryptography.Certificates
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x479065d7, 0x7ac7, 0x4581, 140, 0x3b, 0xd0, 0x70, 0x27, 20, 4, 0x48), ExclusiveTo(typeof(KeyAlgorithmNames)), Version(0x8000000)]
    internal interface IKeyAlgorithmNamesStatics
    {
        string Dsa { get; }

        string Ecdh256 { get; }

        string Ecdh384 { get; }

        string Ecdh521 { get; }

        string Ecdsa256 { get; }

        string Ecdsa384 { get; }

        string Ecdsa521 { get; }

        string Rsa { get; }
    }
}

