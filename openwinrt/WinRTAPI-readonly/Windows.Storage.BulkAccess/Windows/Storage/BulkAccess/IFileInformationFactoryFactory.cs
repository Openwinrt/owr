namespace Windows.Storage.BulkAccess
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.FileProperties;
    using Windows.Storage.Search;

    [Windows.Foundation.Metadata.Guid(0x84ea0e7d, 0xe4a2, 0x4f00, 0x8a, 250, 0xaf, 0x5e, 15, 130, 0x6b, 0xd5), ExclusiveTo(typeof(FileInformationFactory)), Version(0x6020000)]
    internal interface IFileInformationFactoryFactory
    {
        FileInformationFactory CreateWithMode([In] IStorageQueryResultBase queryResult, [In] ThumbnailMode mode);
        FileInformationFactory CreateWithModeAndSize([In] IStorageQueryResultBase queryResult, [In] ThumbnailMode mode, [In] uint requestedThumbnailSize);
        FileInformationFactory CreateWithModeAndSizeAndOptions([In] IStorageQueryResultBase queryResult, [In] ThumbnailMode mode, [In] uint requestedThumbnailSize, [In] ThumbnailOptions thumbnailOptions);
        FileInformationFactory CreateWithModeAndSizeAndOptionsAndFlags([In] IStorageQueryResultBase queryResult, [In] ThumbnailMode mode, [In] uint requestedThumbnailSize, [In] ThumbnailOptions thumbnailOptions, [In] bool delayLoad);
    }
}

