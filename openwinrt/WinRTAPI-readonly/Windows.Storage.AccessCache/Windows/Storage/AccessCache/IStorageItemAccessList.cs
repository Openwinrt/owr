namespace Windows.Storage.AccessCache
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x2caff6ad, 0xde90, 0x47f5, 0xb2, 0xc3, 0xdd, 0x36, 0xc9, 0xfd, 0xd4, 0x53)]
    public interface IStorageItemAccessList
    {
        [Overload("AddOverloadDefaultMetadata")]
        string Add([In] IStorageItem file);
        [Overload("Add")]
        string Add([In] IStorageItem file, [In] string metadata);
        [Overload("AddOrReplaceOverloadDefaultMetadata")]
        void AddOrReplace([In] string token, [In] IStorageItem file);
        [Overload("AddOrReplace")]
        void AddOrReplace([In] string token, [In] IStorageItem file, [In] string metadata);
        bool CheckAccess([In] IStorageItem file);
        void Clear();
        bool ContainsItem([In] string token);
        [Overload("GetFileAsync")]
        IAsyncOperation<StorageFile> GetFileAsync([In] string token);
        [Overload("GetFileWithOptionsAsync")]
        IAsyncOperation<StorageFile> GetFileAsync([In] string token, [In] AccessCacheOptions options);
        [Overload("GetFolderAsync")]
        IAsyncOperation<StorageFolder> GetFolderAsync([In] string token);
        [Overload("GetFolderWithOptionsAsync")]
        IAsyncOperation<StorageFolder> GetFolderAsync([In] string token, [In] AccessCacheOptions options);
        [Overload("GetItemAsync")]
        IAsyncOperation<IStorageItem> GetItemAsync([In] string token);
        [Overload("GetItemWithOptionsAsync")]
        IAsyncOperation<IStorageItem> GetItemAsync([In] string token, [In] AccessCacheOptions options);
        void Remove([In] string token);

        AccessListEntryView Entries { get; }

        uint MaximumItemsAllowed { get; }
    }
}

