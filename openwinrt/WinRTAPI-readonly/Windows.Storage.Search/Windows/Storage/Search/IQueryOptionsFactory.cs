namespace Windows.Storage.Search
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x32e1f8c, 0xa9c1, 0x4e71, 0x80, 0x11, 13, 0xee, 0x9d, 0x48, 0x11, 0xa3), ExclusiveTo(typeof(QueryOptions))]
    internal interface IQueryOptionsFactory
    {
        QueryOptions CreateCommonFileQuery([In] CommonFileQuery query, [In] IIterable<string> fileTypeFilter);
        QueryOptions CreateCommonFolderQuery([In] CommonFolderQuery query);
    }
}

