namespace Windows.Web.AtomPub
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Security.Credentials;
    using Windows.Storage.Streams;
    using Windows.Web.Syndication;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), Activatable(typeof(IAtomPubClientFactory), 0x6020000), Threading(ThreadingModel.Both), DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class AtomPubClient : IAtomPubClient, ISyndicationClient
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public AtomPubClient();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public AtomPubClient([In] PasswordCredential serverCredential);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void CancelAsyncOperations();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<SyndicationItem, TransferProgress> CreateMediaResourceAsync([In] Uri uri, [In] string mediaType, [In] string description, [In] IInputStream mediaStream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<SyndicationItem, TransferProgress> CreateResourceAsync([In] Uri uri, [In] string description, [In] SyndicationItem item);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncActionWithProgress<TransferProgress> DeleteResourceAsync([In] Uri uri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncActionWithProgress<TransferProgress> DeleteResourceItemAsync([In] SyndicationItem item);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<SyndicationFeed, RetrievalProgress> RetrieveFeedAsync([In] Uri uri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<IInputStream, RetrievalProgress> RetrieveMediaResourceAsync([In] Uri uri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<SyndicationItem, RetrievalProgress> RetrieveResourceAsync([In] Uri uri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<ServiceDocument, RetrievalProgress> RetrieveServiceDocumentAsync([In] Uri uri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetRequestHeader([In] string name, [In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncActionWithProgress<TransferProgress> UpdateMediaResourceAsync([In] Uri uri, [In] string mediaType, [In] IInputStream mediaStream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncActionWithProgress<TransferProgress> UpdateResourceAsync([In] Uri uri, [In] SyndicationItem item);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncActionWithProgress<TransferProgress> UpdateResourceItemAsync([In] SyndicationItem item);

        public bool BypassCacheOnRetrieve { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint MaxResponseBufferSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PasswordCredential ProxyCredential { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PasswordCredential ServerCredential { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Timeout { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.Web.Syndication.ISyndicationClient.BypassCacheOnRetrieve { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Web.Syndication.ISyndicationClient.MaxResponseBufferSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PasswordCredential Windows.Web.Syndication.ISyndicationClient.ProxyCredential { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PasswordCredential Windows.Web.Syndication.ISyndicationClient.ServerCredential { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Web.Syndication.ISyndicationClient.Timeout { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

