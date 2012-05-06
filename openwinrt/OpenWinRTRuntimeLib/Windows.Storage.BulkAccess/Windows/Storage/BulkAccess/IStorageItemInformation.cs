namespace Windows.Storage.BulkAccess
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.FileProperties;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x87a5cb8b, 0x8972, 0x4f40, 0x8d, 0xe0, 0xd8, 0x6f, 0xb1, 0x79, 0xd8, 250)]
    public interface IStorageItemInformation
    {
        event TypedEventHandler<IStorageItemInformation, object> PropertiesUpdated;

        event TypedEventHandler<IStorageItemInformation, object> ThumbnailUpdated;

        Windows.Storage.FileProperties.BasicProperties BasicProperties { get; }

        Windows.Storage.FileProperties.DocumentProperties DocumentProperties { get; }

        Windows.Storage.FileProperties.ImageProperties ImageProperties { get; }

        Windows.Storage.FileProperties.MusicProperties MusicProperties { get; }

        StorageItemThumbnail Thumbnail { get; }

        Windows.Storage.FileProperties.VideoProperties VideoProperties { get; }
    }
}

