namespace Windows.Storage.FileProperties
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(StorageItemContentProperties)), Version(0x6020000), Guid(0x5294bad, 0xbc38, 0x48bf, 0x85, 0xd7, 0x77, 14, 14, 0x2a, 0xe0, 0xba)]
    internal interface IStorageItemContentProperties : IStorageItemExtraProperties
    {
        IAsyncOperation<DocumentProperties> GetDocumentPropertiesAsync();
        IAsyncOperation<ImageProperties> GetImagePropertiesAsync();
        IAsyncOperation<MusicProperties> GetMusicPropertiesAsync();
        IAsyncOperation<VideoProperties> GetVideoPropertiesAsync();
    }
}

