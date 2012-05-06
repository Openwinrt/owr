namespace Windows.Web.AtomPub
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;
    using Windows.Web.Syndication;

    [Windows.Foundation.Metadata.Guid(0x35392c38, 0xcded, 0x4d4c, 150, 0x37, 5, 0xf1, 0x5c, 0x1c, 0x94, 6), Version(0x6020000), ExclusiveTo(typeof(AtomPubClient))]
    internal interface IAtomPubClient : ISyndicationClient
    {
        void CancelAsyncOperations();
        IAsyncOperationWithProgress<SyndicationItem, TransferProgress> CreateMediaResourceAsync([In] Uri uri, [In] string mediaType, [In] string description, [In] IInputStream mediaStream);
        IAsyncOperationWithProgress<SyndicationItem, TransferProgress> CreateResourceAsync([In] Uri uri, [In] string description, [In] SyndicationItem item);
        IAsyncActionWithProgress<TransferProgress> DeleteResourceAsync([In] Uri uri);
        IAsyncActionWithProgress<TransferProgress> DeleteResourceItemAsync([In] SyndicationItem item);
        IAsyncOperationWithProgress<IInputStream, RetrievalProgress> RetrieveMediaResourceAsync([In] Uri uri);
        IAsyncOperationWithProgress<SyndicationItem, RetrievalProgress> RetrieveResourceAsync([In] Uri uri);
        IAsyncOperationWithProgress<ServiceDocument, RetrievalProgress> RetrieveServiceDocumentAsync([In] Uri uri);
        IAsyncActionWithProgress<TransferProgress> UpdateMediaResourceAsync([In] Uri uri, [In] string mediaType, [In] IInputStream mediaStream);
        IAsyncActionWithProgress<TransferProgress> UpdateResourceAsync([In] Uri uri, [In] SyndicationItem item);
        IAsyncActionWithProgress<TransferProgress> UpdateResourceItemAsync([In] SyndicationItem item);
    }
}

