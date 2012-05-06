namespace Windows.Storage
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(IKnownFoldersStatics), 0x6020000)]
    public static class KnownFolders
    {
        public static StorageFolder DocumentsLibrary { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static StorageFolder HomeGroup { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static StorageFolder MediaServerDevices { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static StorageFolder MusicLibrary { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static StorageFolder PicturesLibrary { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static StorageFolder RemovableDevices { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static StorageFolder VideosLibrary { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

