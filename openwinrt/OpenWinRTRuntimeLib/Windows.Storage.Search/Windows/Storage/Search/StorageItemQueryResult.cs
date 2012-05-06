namespace Windows.Storage.Search
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Version(0x6020000)]
    public sealed class StorageItemQueryResult : IStorageItemQueryResult, IStorageQueryResultBase
    {
        public event TypedEventHandler<IStorageQueryResultBase, object> ContentsChanged;

        public event TypedEventHandler<IStorageQueryResultBase, object> OptionsChanged;

        public event TypedEventHandler<IStorageQueryResultBase, object> Windows.Storage.Search.IStorageQueryResultBase.ContentsChanged;

        public event TypedEventHandler<IStorageQueryResultBase, object> Windows.Storage.Search.IStorageQueryResultBase.OptionsChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ApplyNewQueryOptions([In] QueryOptions newQueryOptions);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<uint> FindStartIndexAsync([In, Variant] object value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public QueryOptions GetCurrentQueryOptions();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<uint> GetItemCountAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetItemsAsyncDefaultStartAndCount")]
        public IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetItemsAsync")]
        public IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync([In] uint startIndex, [In] uint maxNumberOfItems);

        public StorageFolder Folder { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StorageFolder Windows.Storage.Search.IStorageQueryResultBase.Folder { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

