namespace Windows.Security.Cryptography.Certificates
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), DualApiPartition(version=0x8000000), Version(0x8000000), Static(typeof(ICertificateEnrollmentManagerStatics), 0x8000000)]
    public static class CertificateEnrollmentManager
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<string> CreateRequestAsync([In] CertificateRequestProperties request);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncAction ImportPfxDataAsync([In] string pfxData, [In] string password, [In] ExportOption exportable, [In] KeyProtectionLevel keyProtectionLevel, [In] InstallOptions installOption, [In] string friendlyName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncAction InstallCertificateAsync([In] string certificate, [In] InstallOptions installOption);
    }
}

