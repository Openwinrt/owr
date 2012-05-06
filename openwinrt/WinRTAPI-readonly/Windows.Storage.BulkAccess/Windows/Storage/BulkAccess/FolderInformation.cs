namespace Windows.Storage.BulkAccess
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;
    using Windows.Storage.FileProperties;
    using Windows.Storage.Search;

    [Version(0x6020000)]
    public sealed class FolderInformation : IStorageItemInformation, IStorageFolder, IStorageItem, IStorageItemProperties, IStorageFolderQueryOperations
    {
        public event TypedEventHandler<IStorageItemInformation, object> PropertiesUpdated;

        public event TypedEventHandler<IStorageItemInformation, object> ThumbnailUpdated;

        public event TypedEventHandler<IStorageItemInformation, object> Windows.Storage.BulkAccess.IStorageItemInformation.PropertiesUpdated;

        public event TypedEventHandler<IStorageItemInformation, object> Windows.Storage.BulkAccess.IStorageItemInformation.ThumbnailUpdated;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool AreQueryOptionsSupported([In] QueryOptions queryOptions);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateFileAsyncOverloadDefaultOptions")]
        public IAsyncOperation<StorageFile> CreateFileAsync([In] string desiredName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateFileAsync")]
        public IAsyncOperation<StorageFile> CreateFileAsync([In] string desiredName, [In] CreationCollisionOption options);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateFileQueryOverloadDefault")]
        public StorageFileQueryResult CreateFileQuery();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateFileQuery")]
        public StorageFileQueryResult CreateFileQuery([In] CommonFileQuery query);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public StorageFileQueryResult CreateFileQueryWithOptions([In] QueryOptions queryOptions);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateFolderAsyncOverloadDefaultOptions")]
        public IAsyncOperation<StorageFolder> CreateFolderAsync([In] string desiredName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateFolderAsync")]
        public IAsyncOperation<StorageFolder> CreateFolderAsync([In] string desiredName, [In] CreationCollisionOption options);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateFolderQueryOverloadDefault")]
        public StorageFolderQueryResult CreateFolderQuery();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateFolderQuery")]
        public StorageFolderQueryResult CreateFolderQuery([In] CommonFolderQuery query);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public StorageFolderQueryResult CreateFolderQueryWithOptions([In] QueryOptions queryOptions);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public StorageItemQueryResult CreateItemQuery();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public StorageItemQueryResult CreateItemQueryWithOptions([In] QueryOptions queryOptions);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("DeleteAsyncOverloadDefaultOptions")]
        public IAsyncAction DeleteAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("DeleteAsync")]
        public IAsyncAction DeleteAsync([In] StorageDeleteOption option);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<Windows.Storage.FileProperties.BasicProperties> GetBasicPropertiesAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<StorageFile> GetFileAsync([In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetFilesAsyncOverloadDefaultOptionsStartAndCount")]
        public IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetFilesAsyncOverloadDefaultStartAndCount")]
        public IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync([In] CommonFileQuery query);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetFilesAsync")]
        public IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync([In] CommonFileQuery query, [In] uint startIndex, [In] uint maxItemsToRetrieve);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<StorageFolder> GetFolderAsync([In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetFoldersAsyncOverloadDefaultOptionsStartAndCount")]
        public IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetFoldersAsyncOverloadDefaultStartAndCount")]
        public IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync([In] CommonFolderQuery query);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetFoldersAsync")]
        public IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync([In] CommonFolderQuery query, [In] uint startIndex, [In] uint maxItemsToRetrieve);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IndexedState> GetIndexedStateAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IStorageItem> GetItemAsync([In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetItemsAsyncOverloadDefaultStartAndCount")]
        public IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetItemsAsync")]
        public IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync([In] uint startIndex, [In] uint maxItemsToRetrieve);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
        public IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetThumbnailAsyncOverloadDefaultOptions")]
        public IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode, [In] uint requestedSize);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetThumbnailAsync")]
        public IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode, [In] uint requestedSize, [In] ThumbnailOptions options);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IsCommonFileQuerySupported([In] CommonFileQuery query);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IsCommonFolderQuerySupported([In] CommonFolderQuery query);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IsOfType([In] StorageItemTypes type);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RenameAsyncOverloadDefaultOptions")]
        public IAsyncAction RenameAsync([In] string desiredName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RenameAsync")]
        public IAsyncAction RenameAsync([In] string desiredName, [In] NameCollisionOption option);

        public FileAttributes Attributes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.FileProperties.BasicProperties BasicProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime DateCreated { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string DisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string DisplayType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.FileProperties.DocumentProperties DocumentProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string FolderRelativeId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.FileProperties.ImageProperties ImageProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.FileProperties.MusicProperties MusicProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Path { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StorageItemContentProperties Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StorageItemThumbnail Thumbnail { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.FileProperties.VideoProperties VideoProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.FileProperties.BasicProperties Windows.Storage.BulkAccess.IStorageItemInformation.BasicProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.FileProperties.DocumentProperties Windows.Storage.BulkAccess.IStorageItemInformation.DocumentProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.FileProperties.ImageProperties Windows.Storage.BulkAccess.IStorageItemInformation.ImageProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.FileProperties.MusicProperties Windows.Storage.BulkAccess.IStorageItemInformation.MusicProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StorageItemThumbnail Windows.Storage.BulkAccess.IStorageItemInformation.Thumbnail { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.FileProperties.VideoProperties Windows.Storage.BulkAccess.IStorageItemInformation.VideoProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public FileAttributes Windows.Storage.IStorageItem.Attributes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Storage.IStorageItem.DateCreated { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.IStorageItem.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.IStorageItem.Path { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.IStorageItemProperties.DisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.IStorageItemProperties.DisplayType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.IStorageItemProperties.FolderRelativeId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StorageItemContentProperties Windows.Storage.IStorageItemProperties.Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

