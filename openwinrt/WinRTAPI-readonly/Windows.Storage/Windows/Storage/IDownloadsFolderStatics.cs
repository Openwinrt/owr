namespace Windows.Storage
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(DownloadsFolder)), Windows.Foundation.Metadata.Guid(0x27862ed0, 0x404e, 0x47df, 0xa1, 0xe2, 0xe3, 0x73, 8, 190, 0x7b, 0x37)]
    internal interface IDownloadsFolderStatics
    {
        IAsyncOperation<StorageFile> CreateFileAsync([In] string desiredName);
        IAsyncOperation<StorageFolder> CreateFolderAsync([In] string desiredName);
    }
}

