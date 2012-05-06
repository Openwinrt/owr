namespace Windows.Storage.FileProperties
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class MusicProperties : IMusicProperties, IStorageItemExtraProperties
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync([In] IIterable<string> propertiesToRetrieve);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("SavePropertiesAsyncOverloadDefault")]
        public IAsyncAction SavePropertiesAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("SavePropertiesAsync")]
        public IAsyncAction SavePropertiesAsync([In, HasVariant] IIterable<IKeyValuePair<string, object>> propertiesToSave);

        public string Album { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Artist { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Bitrate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Duration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<string> Genre { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Rating { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint TrackNumber { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Storage.FileProperties.IMusicProperties.Album { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Storage.FileProperties.IMusicProperties.Artist { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Storage.FileProperties.IMusicProperties.Bitrate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Windows.Storage.FileProperties.IMusicProperties.Duration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<string> Windows.Storage.FileProperties.IMusicProperties.Genre { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Storage.FileProperties.IMusicProperties.Rating { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Storage.FileProperties.IMusicProperties.Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Storage.FileProperties.IMusicProperties.TrackNumber { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

