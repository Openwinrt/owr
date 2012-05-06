namespace Windows.Storage
{
    using Windows.Foundation.Metadata;

    [Guid(0x5a2a7520, 0x4802, 0x452d, 0x9a, 0xd9, 0x43, 0x51, 0xad, 0xa7, 0xec, 0x35), Version(0x6020000), ExclusiveTo(typeof(KnownFolders))]
    internal interface IKnownFoldersStatics
    {
        StorageFolder DocumentsLibrary { get; }

        StorageFolder HomeGroup { get; }

        StorageFolder MediaServerDevices { get; }

        StorageFolder MusicLibrary { get; }

        StorageFolder PicturesLibrary { get; }

        StorageFolder RemovableDevices { get; }

        StorageFolder VideosLibrary { get; }
    }
}

