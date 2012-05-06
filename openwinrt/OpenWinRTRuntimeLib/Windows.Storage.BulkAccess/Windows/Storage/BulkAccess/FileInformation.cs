namespace Windows.Storage.BulkAccess
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;
    using Windows.Storage.FileProperties;
    using Windows.Storage.Streams;

    [Version(0x6020000)]
    public sealed class FileInformation : IStorageItemInformation, IStorageFile, IStorageItem, IRandomAccessStreamReference, IInputStreamReference, IStorageItemProperties
    {
        public event TypedEventHandler<IStorageItemInformation, object> PropertiesUpdated;

        public event TypedEventHandler<IStorageItemInformation, object> ThumbnailUpdated;

        public event TypedEventHandler<IStorageItemInformation, object> Windows.Storage.BulkAccess.IStorageItemInformation.PropertiesUpdated;

        public event TypedEventHandler<IStorageItemInformation, object> Windows.Storage.BulkAccess.IStorageItemInformation.ThumbnailUpdated;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction CopyAndReplaceAsync([In] IStorageFile fileToReplace);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CopyOverloadDefaultNameAndOptions")]
        public IAsyncOperation<StorageFile> CopyAsync([In] IStorageFolder destinationFolder);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CopyOverloadDefaultOptions")]
        public IAsyncOperation<StorageFile> CopyAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CopyOverload")]
        public IAsyncOperation<StorageFile> CopyAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName, [In] NameCollisionOption option);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("DeleteAsyncOverloadDefaultOptions")]
        public IAsyncAction DeleteAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("DeleteAsync")]
        public IAsyncAction DeleteAsync([In] StorageDeleteOption option);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<Windows.Storage.FileProperties.BasicProperties> GetBasicPropertiesAsync();
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

        public FileAttributes Attributes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.FileProperties.BasicProperties BasicProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string ContentType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime DateCreated { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string DisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string DisplayType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.FileProperties.DocumentProperties DocumentProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string FileType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

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

