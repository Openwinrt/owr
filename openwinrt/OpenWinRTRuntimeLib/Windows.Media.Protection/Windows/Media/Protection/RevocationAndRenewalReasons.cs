namespace Windows.Media.Protection
{
    using System;
    using Windows.Foundation.Metadata;

    [Flags, Version(0x6020000)]
    public enum RevocationAndRenewalReasons : uint
    {
        BootDriverVerificationFailed = 0x100000,
        ComponentCertificateRevoked = 0x8000,
        ComponentHighSecurityCertificateRevoked = 0x20000,
        ComponentLowSecurityCertificateRevoked = 0x40000,
        ComponentRevoked = 0x2000,
        ComponentSignedWithTestCertificate = 0x1000000,
        EncryptionFailure = 0x10000000,
        GlobalRevocationListAbsent = 0x1000,
        GlobalRevocationListLoadFailed = 0x10,
        InvalidComponentCertificateExtendedKeyUse = 0x4000,
        InvalidComponentCertificateRoot = 0x10000,
        InvalidGlobalRevocationListSignature = 0x20,
        KernelModeComponentLoad = 2,
        UserModeComponentLoad = 1
    }
}

