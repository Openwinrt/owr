namespace Windows.Storage.Search
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xcb43ccc9, 0x446b, 0x4a4f, 190, 0x97, 0x75, 0x77, 0x71, 190, 0x52, 3), Version(0x6020000)]
    public interface IStorageFolderQueryOperations
    {
        bool AreQueryOptionsSupported([In] QueryOptions queryOptions);
        [Overload("CreateFileQueryOverloadDefault")]
        StorageFileQueryResult CreateFileQuery();
        [Overload("CreateFileQuery")]
        StorageFileQueryResult CreateFileQuery([In] CommonFileQuery query);
        StorageFileQueryResult CreateFileQueryWithOptions([In] QueryOptions queryOptions);
        [Overload("CreateFolderQueryOverloadDefault")]
        StorageFolderQueryResult CreateFolderQuery();
        [Overload("CreateFolderQuery")]
        StorageFolderQueryResult CreateFolderQuery([In] CommonFolderQuery query);
        StorageFolderQueryResult CreateFolderQueryWithOptions([In] QueryOptions queryOptions);
        StorageItemQueryResult CreateItemQuery();
        StorageItemQueryResult CreateItemQueryWithOptions([In] QueryOptions queryOptions);
        [Overload("GetFilesAsyncOverloadDefaultStartAndCount")]
        IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync([In] CommonFileQuery query);
        [Overload("GetFilesAsync")]
        IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync([In] CommonFileQuery query, [In] uint startIndex, [In] uint maxItemsToRetrieve);
        [Overload("GetFoldersAsyncOverloadDefaultStartAndCount")]
        IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync([In] CommonFolderQuery query);
        [Overload("GetFoldersAsync")]
        IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync([In] CommonFolderQuery query, [In] uint startIndex, [In] uint maxItemsToRetrieve);
        IAsyncOperation<IndexedState> GetIndexedStateAsync();
        [Overload("GetItemsAsync")]
        IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync([In] uint startIndex, [In] uint maxItemsToRetrieve);
        bool IsCommonFileQuerySupported([In] CommonFileQuery query);
        bool IsCommonFolderQuerySupported([In] CommonFolderQuery query);
    }
}

