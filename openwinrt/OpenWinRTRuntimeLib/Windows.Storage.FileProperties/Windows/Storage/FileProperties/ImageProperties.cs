namespace Windows.Storage.FileProperties
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ImageProperties : IImageProperties, IStorageItemExtraProperties
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync([In] IIterable<string> propertiesToRetrieve);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("SavePropertiesAsyncOverloadDefault")]
        public IAsyncAction SavePropertiesAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("SavePropertiesAsync")]
        public IAsyncAction SavePropertiesAsync([In, HasVariant] IIterable<IKeyValuePair<string, object>> propertiesToSave);

        public Windows.Foundation.DateTime DateTaken { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Height { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<string> Keywords { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Rating { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Width { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Storage.FileProperties.IImageProperties.DateTaken { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Storage.FileProperties.IImageProperties.Height { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<string> Windows.Storage.FileProperties.IImageProperties.Keywords { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Storage.FileProperties.IImageProperties.Rating { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Storage.FileProperties.IImageProperties.Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Storage.FileProperties.IImageProperties.Width { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

