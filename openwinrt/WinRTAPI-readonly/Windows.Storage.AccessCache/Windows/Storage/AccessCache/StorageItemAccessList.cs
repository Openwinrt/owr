namespace Windows.Storage.AccessCache
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Version(0x6020000)]
    public sealed class StorageItemAccessList : IStorageItemAccessList
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AddOverloadDefaultMetadata")]
        public string Add([In] IStorageItem file);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("Add")]
        public string Add([In] IStorageItem file, [In] string metadata);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AddOrReplaceOverloadDefaultMetadata")]
        public void AddOrReplace([In] string token, [In] IStorageItem file);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AddOrReplace")]
        public void AddOrReplace([In] string token, [In] IStorageItem file, [In] string metadata);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool CheckAccess([In] IStorageItem file);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool ContainsItem([In] string token);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetFileAsync")]
        public IAsyncOperation<StorageFile> GetFileAsync([In] string token);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetFileWithOptionsAsync")]
        public IAsyncOperation<StorageFile> GetFileAsync([In] string token, [In] AccessCacheOptions options);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetFolderAsync")]
        public IAsyncOperation<StorageFolder> GetFolderAsync([In] string token);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetFolderWithOptionsAsync")]
        public IAsyncOperation<StorageFolder> GetFolderAsync([In] string token, [In] AccessCacheOptions options);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetItemAsync")]
        public IAsyncOperation<IStorageItem> GetItemAsync([In] string token);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetItemWithOptionsAsync")]
        public IAsyncOperation<IStorageItem> GetItemAsync([In] string token, [In] AccessCacheOptions options);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Remove([In] string token);

        public AccessListEntryView Entries { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint MaximumItemsAllowed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public AccessListEntryView Windows.Storage.AccessCache.IStorageItemAccessList.Entries { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Storage.AccessCache.IStorageItemAccessList.MaximumItemsAllowed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

