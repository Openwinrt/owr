namespace Windows.Security.Cryptography.Core
{
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(EncryptedAndAuthenticatedData)), Guid(0x6fa42fe7, 0x1ecb, 0x4b00, 190, 0xa5, 0x60, 0xb8, 0x3f, 0x86, 0x2f, 0x17), Version(0x6020000)]
    internal interface IEncryptedAndAuthenticatedData
    {
        IBuffer AuthenticationTag { get; }

        IBuffer EncryptedData { get; }
    }
}

