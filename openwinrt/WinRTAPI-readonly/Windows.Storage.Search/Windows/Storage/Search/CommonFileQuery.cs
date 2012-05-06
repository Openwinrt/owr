namespace Windows.Storage.Search
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum CommonFileQuery
    {
        DefaultQuery,
        OrderByName,
        OrderByTitle,
        OrderByMusicProperties,
        OrderBySearchRank,
        OrderByDate
    }
}

