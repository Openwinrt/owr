namespace Windows.Storage.Search
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Activatable(typeof(IQueryOptionsFactory), 0x6020000), Version(0x6020000), Activatable(0x6020000)]
    public sealed class QueryOptions : IQueryOptions
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public QueryOptions();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public QueryOptions([In] CommonFolderQuery query);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public QueryOptions([In] CommonFileQuery query, [In] IIterable<string> fileTypeFilter);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void LoadFromString([In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string SaveToString();

        public string ApplicationSearchFilter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Storage.Search.DateStackOption DateStackOption { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<string> FileTypeFilter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.Search.FolderDepth FolderDepth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string GroupPropertyName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.Search.IndexerOption IndexerOption { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<SortEntry> SortOrder { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string UserSearchFilter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Storage.Search.IQueryOptions.ApplicationSearchFilter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Storage.Search.DateStackOption Windows.Storage.Search.IQueryOptions.DateStackOption { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<string> Windows.Storage.Search.IQueryOptions.FileTypeFilter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.Search.FolderDepth Windows.Storage.Search.IQueryOptions.FolderDepth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Storage.Search.IQueryOptions.GroupPropertyName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.Search.IndexerOption Windows.Storage.Search.IQueryOptions.IndexerOption { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Storage.Search.IQueryOptions.Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<SortEntry> Windows.Storage.Search.IQueryOptions.SortOrder { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.Search.IQueryOptions.UserSearchFilter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

