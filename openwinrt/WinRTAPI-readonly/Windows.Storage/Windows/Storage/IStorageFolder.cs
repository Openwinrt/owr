namespace Windows.Storage
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x72d1cb78, 0xb3ef, 0x4f75, 0xa8, 11, 0x6f, 0xd9, 0xda, 0xe2, 0x94, 0x4b)]
    public interface IStorageFolder : IStorageItem
    {
        [Overload("CreateFileAsyncOverloadDefaultOptions")]
        IAsyncOperation<StorageFile> CreateFileAsync([In] string desiredName);
        [Overload("CreateFileAsync")]
        IAsyncOperation<StorageFile> CreateFileAsync([In] string desiredName, [In] CreationCollisionOption options);
        [Overload("CreateFolderAsyncOverloadDefaultOptions")]
        IAsyncOperation<StorageFolder> CreateFolderAsync([In] string desiredName);
        [Overload("CreateFolderAsync")]
        IAsyncOperation<StorageFolder> CreateFolderAsync([In] string desiredName, [In] CreationCollisionOption options);
        IAsyncOperation<StorageFile> GetFileAsync([In] string name);
        [Overload("GetFilesAsyncOverloadDefaultOptionsStartAndCount")]
        IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync();
        IAsyncOperation<StorageFolder> GetFolderAsync([In] string name);
        [Overload("GetFoldersAsyncOverloadDefaultOptionsStartAndCount")]
        IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync();
        IAsyncOperation<IStorageItem> GetItemAsync([In] string name);
        [Overload("GetItemsAsyncOverloadDefaultStartAndCount")]
        IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync();
    }
}

