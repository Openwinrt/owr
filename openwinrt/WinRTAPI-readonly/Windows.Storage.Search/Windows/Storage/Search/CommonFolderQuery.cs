namespace Windows.Storage.Search
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum CommonFolderQuery
    {
        DefaultQuery = 0,
        GroupByAlbum = 0x67,
        GroupByAlbumArtist = 0x68,
        GroupByArtist = 0x66,
        GroupByAuthor = 110,
        GroupByComposer = 0x69,
        GroupByGenre = 0x6a,
        GroupByMonth = 0x65,
        GroupByPublishedYear = 0x6b,
        GroupByRating = 0x6c,
        GroupByTag = 0x6d,
        GroupByType = 0x6f,
        GroupByYear = 100
    }
}

