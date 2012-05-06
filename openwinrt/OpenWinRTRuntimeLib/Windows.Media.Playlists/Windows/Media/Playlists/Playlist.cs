namespace Windows.Media.Playlists
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Activatable(0x6020000), Threading(ThreadingModel.Both), Version(0x6020000), Static(typeof(IPlaylistStatics), 0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class Playlist : IPlaylist
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Playlist();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<Playlist> LoadAsync([In] IStorageFile file);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("SaveAsAsync")]
        public IAsyncOperation<IStorageFile> SaveAsAsync([In] IStorageFolder saveLocation, [In] string desiredName, [In] NameCollisionOption option);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("SaveAsWithFormatAsync")]
        public IAsyncOperation<IStorageFile> SaveAsAsync([In] IStorageFolder saveLocation, [In] string desiredName, [In] NameCollisionOption option, [In] PlaylistFormat playlistFormat);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction SaveAsync();

        public IVector<IStorageFile> Files { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<IStorageFile> Windows.Media.Playlists.IPlaylist.Files { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

