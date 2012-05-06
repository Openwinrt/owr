namespace Windows.Storage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.FileProperties;
    using Windows.Storage.Streams;

    [Version(0x6020000), Static(typeof(IStorageFileStatics), 0x6020000)]
    public sealed class StorageFile : IStorageFile, IStorageItem, IRandomAccessStreamReference, IInputStreamReference, IStorageItemProperties
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction CopyAndReplaceAsync([In] IStorageFile fileToReplace);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CopyOverloadDefaultNameAndOptions")]
        public IAsyncOperation<StorageFile> CopyAsync([In] IStorageFolder destinationFolder);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CopyOverloadDefaultOptions")]
        public IAsyncOperation<StorageFile> CopyAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CopyOverload")]
        public IAsyncOperation<StorageFile> CopyAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName, [In] NameCollisionOption option);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<StorageFile> CreateStreamedFileAsync([In] string displayNameWithExtension, [In] StreamedFileDataRequestedHandler dataRequested, [In] IRandomAccessStreamReference thumbnail);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<StorageFile> CreateStreamedFileFromUriAsync([In] string displayNameWithExtension, [In] Uri uri, [In] IRandomAccessStreamReference thumbnail);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("DeleteAsyncOverloadDefaultOptions")]
        public IAsyncAction DeleteAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("DeleteAsync")]
        public IAsyncAction DeleteAsync([In] StorageDeleteOption option);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<BasicProperties> GetBasicPropertiesAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<StorageFile> GetFileFromApplicationUriAsync([In] Uri uri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<StorageFile> GetFileFromPathAsync([In] string path);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
        public IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetThumbnailAsyncOverloadDefaultOptions")]
        public IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode, [In] uint requestedSize);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetThumbnailAsync")]
        public IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode, [In] uint requestedSize, [In] ThumbnailOptions options);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IsOfType([In] StorageItemTypes type);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction MoveAndReplaceAsync([In] IStorageFile fileToReplace);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("MoveOverloadDefaultNameAndOptions")]
        public IAsyncAction MoveAsync([In] IStorageFolder destinationFolder);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("MoveOverloadDefaultOptions")]
        public IAsyncAction MoveAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("MoveOverload")]
        public IAsyncAction MoveAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName, [In] NameCollisionOption option);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IRandomAccessStream> OpenAsync([In] FileAccessMode accessMode);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IRandomAccessStreamWithContentType> OpenReadAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IInputStream> OpenSequentialReadAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RenameAsyncOverloadDefaultOptions")]
        public IAsyncAction RenameAsync([In] string desiredName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RenameAsync")]
        public IAsyncAction RenameAsync([In] string desiredName, [In] NameCollisionOption option);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<StorageFile> ReplaceWithStreamedFileAsync([In] IStorageFile fileToReplace, [In] StreamedFileDataRequestedHandler dataRequested, [In] IRandomAccessStreamReference thumbnail);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<StorageFile> ReplaceWithStreamedFileFromUriAsync([In] IStorageFile fileToReplace, [In] Uri uri, [In] IRandomAccessStreamReference thumbnail);

        public FileAttributes Attributes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string ContentType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime DateCreated { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string DisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string DisplayType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string FileType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string FolderRelativeId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Path { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StorageItemContentProperties Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.IStorageFile.ContentType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.IStorageFile.FileType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

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

