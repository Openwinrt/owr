namespace Windows.Security.Cryptography.Certificates
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x8000000), Flags]
    public enum InstallOptions : uint
    {
        DeleteExpired = 1,
        None = 0
    }
}

