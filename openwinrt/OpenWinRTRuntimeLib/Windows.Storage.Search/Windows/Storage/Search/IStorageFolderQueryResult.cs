namespace Windows.Storage.Search
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x6654c911, 0x7d66, 0x46fa, 0xae, 0xcf, 0xe4, 0xa4, 0xba, 0xa9, 0x3a, 0xb8), ExclusiveTo(typeof(StorageFolderQueryResult)), Version(0x6020000)]
    internal interface IStorageFolderQueryResult : IStorageQueryResultBase
    {
        [Overload("GetFoldersAsyncDefaultStartAndCount")]
        IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync();
        [Overload("GetFoldersAsync")]
        IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync([In] uint startIndex, [In] uint maxNumberOfItems);
    }
}

