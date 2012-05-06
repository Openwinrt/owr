namespace Windows.Storage
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.FileProperties;

    [Windows.Foundation.Metadata.Guid(0x86664478, 0x8029, 0x46fe, 0xa7, 0x89, 0x1c, 0x2f, 0x3e, 0x2f, 0xfb, 0x5c), Version(0x6020000)]
    public interface IStorageItemProperties
    {
        [Overload("GetThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
        IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode);
        [Overload("GetThumbnailAsyncOverloadDefaultOptions")]
        IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode, [In] uint requestedSize);
        [Overload("GetThumbnailAsync")]
        IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode, [In] uint requestedSize, [In] ThumbnailOptions options);

        string DisplayName { get; }

        string DisplayType { get; }

        string FolderRelativeId { get; }

        StorageItemContentProperties Properties { get; }
    }
}

