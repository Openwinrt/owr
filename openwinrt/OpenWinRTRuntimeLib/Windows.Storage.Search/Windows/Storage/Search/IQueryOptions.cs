namespace Windows.Storage.Search
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x1e5e46ee, 0xf45, 0x4838, 0xa8, 0xe9, 0xd0, 0x47, 0x9d, 0x44, 0x6c, 0x30), Version(0x6020000), ExclusiveTo(typeof(QueryOptions))]
    internal interface IQueryOptions
    {
        void LoadFromString([In] string value);
        string SaveToString();

        string ApplicationSearchFilter { get; [param: In] set; }

        Windows.Storage.Search.DateStackOption DateStackOption { get; }

        IVector<string> FileTypeFilter { get; }

        Windows.Storage.Search.FolderDepth FolderDepth { get; [param: In] set; }

        string GroupPropertyName { get; }

        Windows.Storage.Search.IndexerOption IndexerOption { get; [param: In] set; }

        string Language { get; [param: In] set; }

        IVector<SortEntry> SortOrder { get; }

        string UserSearchFilter { get; [param: In] set; }
    }
}

