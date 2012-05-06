namespace Windows.Security.Cryptography.Certificates
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x8000000), Version(0x8000000), Static(typeof(IHashAlgorithmNamesStatics), 0x8000000), Threading(ThreadingModel.Both)]
    public static class HashAlgorithmNames
    {
        public static string Sha1 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Sha256 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Sha384 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Sha512 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

