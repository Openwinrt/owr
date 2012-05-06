namespace Windows.Storage.Search
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe8948079, 0x9d58, 0x47b8, 0xb2, 0xb2, 0x41, 0xb0, 0x7f, 0x47, 0x95, 0xf9), ExclusiveTo(typeof(StorageItemQueryResult))]
    internal interface IStorageItemQueryResult : IStorageQueryResultBase
    {
        [Overload("GetItemsAsyncDefaultStartAndCount")]
        IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync();
        [Overload("GetItemsAsync")]
        IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync([In] uint startIndex, [In] uint maxNumberOfItems);
    }
}

