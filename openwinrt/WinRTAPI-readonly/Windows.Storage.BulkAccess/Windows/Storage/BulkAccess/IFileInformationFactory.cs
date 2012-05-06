namespace Windows.Storage.BulkAccess
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(FileInformationFactory)), Windows.Foundation.Metadata.Guid(0x401d88be, 0x960f, 0x4d6d, 0xa7, 0xd0, 0x1a, 0x38, 0x61, 0xe7, 0x6c, 0x83)]
    internal interface IFileInformationFactory
    {
        [Overload("GetFilesAsyncDefaultStartAndCount")]
        IAsyncOperation<IVectorView<FileInformation>> GetFilesAsync();
        [Overload("GetFilesAsync")]
        IAsyncOperation<IVectorView<FileInformation>> GetFilesAsync([In] uint startIndex, [In] uint maxItemsToRetrieve);
        [Overload("GetFoldersAsyncDefaultStartAndCount")]
        IAsyncOperation<IVectorView<FolderInformation>> GetFoldersAsync();
        [Overload("GetFoldersAsync")]
        IAsyncOperation<IVectorView<FolderInformation>> GetFoldersAsync([In] uint startIndex, [In] uint maxItemsToRetrieve);
        [Overload("GetItemsAsyncDefaultStartAndCount")]
        IAsyncOperation<IVectorView<IStorageItemInformation>> GetItemsAsync();
        [Overload("GetItemsAsync")]
        IAsyncOperation<IVectorView<IStorageItemInformation>> GetItemsAsync([In] uint startIndex, [In] uint maxItemsToRetrieve);
        object GetVirtualizedFilesVector();
        object GetVirtualizedFoldersVector();
        object GetVirtualizedItemsVector();
    }
}

