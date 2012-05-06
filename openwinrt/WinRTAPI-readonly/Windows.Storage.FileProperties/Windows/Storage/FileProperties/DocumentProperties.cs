namespace Windows.Storage.FileProperties
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class DocumentProperties : IDocumentProperties, IStorageItemExtraProperties
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync([In] IIterable<string> propertiesToRetrieve);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("SavePropertiesAsyncOverloadDefault")]
        public IAsyncAction SavePropertiesAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("SavePropertiesAsync")]
        public IAsyncAction SavePropertiesAsync([In, HasVariant] IIterable<IKeyValuePair<string, object>> propertiesToSave);

        public IVector<string> Author { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Comment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<string> Keywords { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<string> Windows.Storage.FileProperties.IDocumentProperties.Author { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.FileProperties.IDocumentProperties.Comment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<string> Windows.Storage.FileProperties.IDocumentProperties.Keywords { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.FileProperties.IDocumentProperties.Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

