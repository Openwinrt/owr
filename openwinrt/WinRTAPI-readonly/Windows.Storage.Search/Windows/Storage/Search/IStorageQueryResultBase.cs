namespace Windows.Storage.Search
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xc297d70d, 0x7353, 0x47ab, 0xba, 0x58, 140, 0x61, 0x42, 0x5d, 0xc5, 0x4b)]
    public interface IStorageQueryResultBase
    {
        event TypedEventHandler<IStorageQueryResultBase, object> ContentsChanged;

        event TypedEventHandler<IStorageQueryResultBase, object> OptionsChanged;

        void ApplyNewQueryOptions([In] QueryOptions newQueryOptions);
        IAsyncOperation<uint> FindStartIndexAsync([In, Variant] object value);
        QueryOptions GetCurrentQueryOptions();
        IAsyncOperation<uint> GetItemCountAsync();

        StorageFolder Folder { get; }
    }
}

