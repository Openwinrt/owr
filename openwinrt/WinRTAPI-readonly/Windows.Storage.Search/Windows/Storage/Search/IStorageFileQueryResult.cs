namespace Windows.Storage.Search
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(StorageFileQueryResult)), Windows.Foundation.Metadata.Guid(0x52fda447, 0x2baa, 0x412c, 0xb2, 0x9f, 0xd4, 0xb1, 0x77, 0x8e, 250, 30)]
    internal interface IStorageFileQueryResult : IStorageQueryResultBase
    {
        [Overload("GetFilesAsyncDefaultStartAndCount")]
        IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync();
        [Overload("GetFilesAsync")]
        IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync([In] uint startIndex, [In] uint maxNumberOfItems);
    }
}

