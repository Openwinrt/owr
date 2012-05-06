namespace Windows.Media.Playlists
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Windows.Foundation.Metadata.Guid(0xccae6950, 0x8879, 0x41d6, 0xb2, 0x5d, 0x77, 0x31, 0xaf, 0xcc, 0x59, 0xdd), Version(0x6020000), ExclusiveTo(typeof(Playlist))]
    internal interface IPlaylist
    {
        [Overload("SaveAsAsync")]
        IAsyncOperation<IStorageFile> SaveAsAsync([In] IStorageFolder saveLocation, [In] string desiredName, [In] NameCollisionOption option);
        [Overload("SaveAsWithFormatAsync")]
        IAsyncOperation<IStorageFile> SaveAsAsync([In] IStorageFolder saveLocation, [In] string desiredName, [In] NameCollisionOption option, [In] PlaylistFormat playlistFormat);
        IAsyncAction SaveAsync();

        IVector<IStorageFile> Files { get; }
    }
}

