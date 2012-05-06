namespace Windows.ApplicationModel.Search
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(SearchPaneResultSuggestionChosenEventArgs)), Guid(0xc8316cc0, 0xaed2, 0x41e0, 0xbc, 0xe0, 0xc2, 0x6c, 0xa7, 0x4f, 0x85, 0xec)]
    internal interface ISearchPaneResultSuggestionChosenEventArgs
    {
        string Tag { get; }
    }
}

