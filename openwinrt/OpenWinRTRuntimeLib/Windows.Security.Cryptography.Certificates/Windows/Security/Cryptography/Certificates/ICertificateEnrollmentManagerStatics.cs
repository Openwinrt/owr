namespace Windows.Security.Cryptography.Certificates
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(CertificateEnrollmentManager)), Windows.Foundation.Metadata.Guid(0x8846ef3f, 0xa986, 0x48fb, 0x9f, 0xd7, 0x9a, 0xec, 6, 0x93, 0x5b, 0xf1), Version(0x8000000)]
    internal interface ICertificateEnrollmentManagerStatics
    {
        IAsyncOperation<string> CreateRequestAsync([In] CertificateRequestProperties request);
        IAsyncAction ImportPfxDataAsync([In] string pfxData, [In] string password, [In] ExportOption exportable, [In] KeyProtectionLevel keyProtectionLevel, [In] InstallOptions installOption, [In] string friendlyName);
        IAsyncAction InstallCertificateAsync([In] string certificate, [In] InstallOptions installOption);
    }
}

