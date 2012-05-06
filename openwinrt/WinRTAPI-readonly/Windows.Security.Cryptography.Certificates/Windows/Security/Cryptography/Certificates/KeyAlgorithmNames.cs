namespace Windows.Security.Cryptography.Certificates
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x8000000), Threading(ThreadingModel.Both), DualApiPartition(version=0x8000000), Static(typeof(IKeyAlgorithmNamesStatics), 0x8000000)]
    public static class KeyAlgorithmNames
    {
        public static string Dsa { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Ecdh256 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Ecdh384 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Ecdh521 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Ecdsa256 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Ecdsa384 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Ecdsa521 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Rsa { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

