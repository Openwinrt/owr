namespace Windows.Storage.FileProperties
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class StorageItemContentProperties : IStorageItemContentProperties, IStorageItemExtraProperties
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<DocumentProperties> GetDocumentPropertiesAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<ImageProperties> GetImagePropertiesAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<MusicProperties> GetMusicPropertiesAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<VideoProperties> GetVideoPropertiesAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync([In] IIterable<string> propertiesToRetrieve);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("SavePropertiesAsyncOverloadDefault")]
        public IAsyncAction SavePropertiesAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("SavePropertiesAsync")]
        public IAsyncAction SavePropertiesAsync([In, HasVariant] IIterable<IKeyValuePair<string, object>> propertiesToSave);
    }
}

