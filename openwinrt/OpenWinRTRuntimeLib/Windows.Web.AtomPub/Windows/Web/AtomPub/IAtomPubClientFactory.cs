namespace Windows.Web.AtomPub
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Security.Credentials;

    [ExclusiveTo(typeof(AtomPubClient)), Windows.Foundation.Metadata.Guid(0x49d55012, 0x57cb, 0x4bde, 0xab, 0x9f, 0x26, 0x10, 0xb1, 0x72, 0x77, 0x7b), Version(0x6020000)]
    internal interface IAtomPubClientFactory
    {
        AtomPubClient CreateAtomPubClientWithCredentials([In] PasswordCredential serverCredential);
    }
}

