namespace Windows.Web.Syndication
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Security.Credentials;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x2ec4b32c, 0xa79b, 0x4114, 0xb2, 0x9a, 5, 0xdf, 0xfb, 0xaf, 0xb9, 0xa4), ExclusiveTo(typeof(SyndicationClient))]
    internal interface ISyndicationClientFactory
    {
        SyndicationClient CreateSyndicationClient([In] PasswordCredential serverCredential);
    }
}

