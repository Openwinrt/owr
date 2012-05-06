namespace Windows.Security.Cryptography.Certificates
{
    using System;
    using Windows.Foundation.Metadata;

    [Flags, Version(0x8000000)]
    public enum EnrollKeyUsages : uint
    {
        All = 0xffffff,
        Decryption = 1,
        KeyAgreement = 4,
        None = 0,
        Signing = 2
    }
}

