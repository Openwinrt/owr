namespace Windows.Security.Cryptography.Certificates
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x8000000), Static(typeof(IKeyStorageProviderNamesStatics), 0x8000000), Threading(ThreadingModel.Both), DualApiPartition(version=0x8000000)]
    public static class KeyStorageProviderNames
    {
        public static string PlatformKeyStorageProvider { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string SmartcardKeyStorageProvider { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string SoftwareKeyStorageProvider { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

