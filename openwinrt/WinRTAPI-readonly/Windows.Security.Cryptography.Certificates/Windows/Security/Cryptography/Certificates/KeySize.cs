namespace Windows.Security.Cryptography.Certificates
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x8000000)]
    public enum KeySize
    {
        Invalid = 0,
        Rsa2048 = 0x800,
        Rsa4096 = 0x1000
    }
}

