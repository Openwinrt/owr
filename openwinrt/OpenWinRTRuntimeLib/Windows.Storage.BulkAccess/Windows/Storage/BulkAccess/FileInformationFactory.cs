namespace Windows.Storage.BulkAccess
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.FileProperties;
    using Windows.Storage.Search;

    [Version(0x6020000), Activatable(typeof(IFileInformationFactoryFactory), 0x6020000)]
    public sealed class FileInformationFactory : IFileInformationFactory
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public FileInformationFactory([In] IStorageQueryResultBase queryResult, [In] ThumbnailMode mode);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public FileInformationFactory([In] IStorageQueryResultBase queryResult, [In] ThumbnailMode mode, [In] uint requestedThumbnailSize);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public FileInformationFactory([In] IStorageQueryResultBase queryResult, [In] ThumbnailMode mode, [In] uint requestedThumbnailSize, [In] ThumbnailOptions thumbnailOptions);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public FileInformationFactory([In] IStorageQueryResultBase queryResult, [In] ThumbnailMode mode, [In] uint requestedThumbnailSize, [In] ThumbnailOptions thumbnailOptions, [In] bool delayLoad);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetFilesAsyncDefaultStartAndCount")]
        public IAsyncOperation<IVectorView<FileInformation>> GetFilesAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetFilesAsync")]
        public IAsyncOperation<IVectorView<FileInformation>> GetFilesAsync([In] uint startIndex, [In] uint maxItemsToRetrieve);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetFoldersAsyncDefaultStartAndCount")]
        public IAsyncOperation<IVectorView<FolderInformation>> GetFoldersAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetFoldersAsync")]
        public IAsyncOperation<IVectorView<FolderInformation>> GetFoldersAsync([In] uint startIndex, [In] uint maxItemsToRetrieve);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetItemsAsyncDefaultStartAndCount")]
        public IAsyncOperation<IVectorView<IStorageItemInformation>> GetItemsAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetItemsAsync")]
        public IAsyncOperation<IVectorView<IStorageItemInformation>> GetItemsAsync([In] uint startIndex, [In] uint maxItemsToRetrieve);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public object GetVirtualizedFilesVector();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public object GetVirtualizedFoldersVector();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public object GetVirtualizedItemsVector();
    }
}

