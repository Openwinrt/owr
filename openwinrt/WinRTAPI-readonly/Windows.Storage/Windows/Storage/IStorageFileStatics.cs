namespace Windows.Storage
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Windows.Foundation.Metadata.Guid(0x5984c710, 0xdaf2, 0x43c8, 0x8b, 180, 0xa4, 0xd3, 0xea, 0xcf, 0xd0, 0x3f), Version(0x6020000), ExclusiveTo(typeof(StorageFile))]
    internal interface IStorageFileStatics
    {
        IAsyncOperation<StorageFile> CreateStreamedFileAsync([In] string displayNameWithExtension, [In] StreamedFileDataRequestedHandler dataRequested, [In] IRandomAccessStreamReference thumbnail);
        IAsyncOperation<StorageFile> CreateStreamedFileFromUriAsync([In] string displayNameWithExtension, [In] Uri uri, [In] IRandomAccessStreamReference thumbnail);
        IAsyncOperation<StorageFile> GetFileFromApplicationUriAsync([In] Uri uri);
        IAsyncOperation<StorageFile> GetFileFromPathAsync([In] string path);
        IAsyncOperation<StorageFile> ReplaceWithStreamedFileAsync([In] IStorageFile fileToReplace, [In] StreamedFileDataRequestedHandler dataRequested, [In] IRandomAccessStreamReference thumbnail);
        IAsyncOperation<StorageFile> ReplaceWithStreamedFileFromUriAsync([In] IStorageFile fileToReplace, [In] Uri uri, [In] IRandomAccessStreamReference thumbnail);
    }
}

