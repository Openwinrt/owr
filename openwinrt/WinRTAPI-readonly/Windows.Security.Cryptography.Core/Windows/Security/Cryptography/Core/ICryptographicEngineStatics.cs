namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x9fea0639, 0x6ff7, 0x4c85, 160, 0x95, 0x95, 0xeb, 0x31, 0x71, 0x5e, 0xb9), ExclusiveTo(typeof(CryptographicEngine))]
    internal interface ICryptographicEngineStatics
    {
        IBuffer Decrypt([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer iv);
        IBuffer DecryptAndAuthenticate([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer nonce, [In] IBuffer authenticationTag, [In] IBuffer authenticatedData);
        IBuffer DeriveKeyMaterial([In] CryptographicKey key, [In] KeyDerivationParameters parameters, [In] uint desiredKeySize);
        IBuffer Encrypt([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer iv);
        EncryptedAndAuthenticatedData EncryptAndAuthenticate([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer nonce, [In] IBuffer authenticatedData);
        IBuffer Sign([In] CryptographicKey key, [In] IBuffer data);
        bool VerifySignature([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer signature);
    }
}

