namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Security.Credentials;

    [Windows.Foundation.Metadata.Guid(0x9e18a9b7, 0x7249, 0x4b45, 0xb2, 0x29, 0x7d, 0xf8, 0x95, 0xa5, 0xa1, 0xf5), Version(0x6020000)]
    public interface ISyndicationClient
    {
        IAsyncOperationWithProgress<SyndicationFeed, RetrievalProgress> RetrieveFeedAsync([In] Uri uri);
        void SetRequestHeader([In] string name, [In] string value);

        bool BypassCacheOnRetrieve { get; [param: In] set; }

        uint MaxResponseBufferSize { get; [param: In] set; }

        PasswordCredential ProxyCredential { get; [param: In] set; }

        PasswordCredential ServerCredential { get; [param: In] set; }

        uint Timeout { get; [param: In] set; }
    }
}

