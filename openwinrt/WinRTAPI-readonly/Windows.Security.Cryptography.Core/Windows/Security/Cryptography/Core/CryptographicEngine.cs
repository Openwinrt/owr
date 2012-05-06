namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Static(typeof(ICryptographicEngineStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), DualApiPartition(version=0x6020000), Threading(ThreadingModel.Both)]
    public static class CryptographicEngine
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IBuffer Decrypt([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer iv);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IBuffer DecryptAndAuthenticate([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer nonce, [In] IBuffer authenticationTag, [In] IBuffer authenticatedData);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IBuffer DeriveKeyMaterial([In] CryptographicKey key, [In] KeyDerivationParameters parameters, [In] uint desiredKeySize);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IBuffer Encrypt([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer iv);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static EncryptedAndAuthenticatedData EncryptAndAuthenticate([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer nonce, [In] IBuffer authenticatedData);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IBuffer Sign([In] CryptographicKey key, [In] IBuffer data);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool VerifySignature([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer signature);
    }
}

