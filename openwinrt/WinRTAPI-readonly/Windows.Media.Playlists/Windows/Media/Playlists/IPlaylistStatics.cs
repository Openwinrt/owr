namespace Windows.Media.Playlists
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Windows.Foundation.Metadata.Guid(0xc5c331cd, 0x81f9, 0x4ff3, 0x95, 0xb9, 0x70, 0xb6, 0xff, 4, 0x6b, 0x68), ExclusiveTo(typeof(Playlist)), Version(0x6020000)]
    internal interface IPlaylistStatics
    {
        IAsyncOperation<Playlist> LoadAsync([In] IStorageFile file);
    }
}

