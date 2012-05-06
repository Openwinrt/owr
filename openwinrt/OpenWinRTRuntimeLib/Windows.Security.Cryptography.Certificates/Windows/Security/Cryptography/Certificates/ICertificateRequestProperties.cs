namespace Windows.Security.Cryptography.Certificates
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x487e84f6, 0x94e2, 0x4dce, 0x88, 0x33, 0x1a, 0x70, 10, 0x37, 0xa2, 0x9a), Version(0x8000000), ExclusiveTo(typeof(CertificateRequestProperties))]
    internal interface ICertificateRequestProperties
    {
        ExportOption Exportable { get; [param: In] set; }

        string FriendlyName { get; [param: In] set; }

        string HashAlgorithmName { get; [param: In] set; }

        string KeyAlgorithmName { get; [param: In] set; }

        Windows.Security.Cryptography.Certificates.KeyProtectionLevel KeyProtectionLevel { get; [param: In] set; }

        uint KeySize { get; [param: In] set; }

        string KeyStorageProviderName { get; [param: In] set; }

        EnrollKeyUsages KeyUsages { get; [param: In] set; }

        string Subject { get; [param: In] set; }
    }
}

