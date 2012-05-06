namespace Windows.Storage.FileProperties
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x693dd42f, 0xdbe7, 0x49b5, 0xb3, 0xb3, 40, 0x93, 0xac, 0x5d, 0x34, 0x23), ExclusiveTo(typeof(StorageItemThumbnail)), Version(0x6020000)]
    internal interface IThumbnailProperties
    {
        uint OriginalHeight { get; }

        uint OriginalWidth { get; }

        bool ReturnedSmallerCachedSize { get; }

        ThumbnailType Type { get; }
    }
}

