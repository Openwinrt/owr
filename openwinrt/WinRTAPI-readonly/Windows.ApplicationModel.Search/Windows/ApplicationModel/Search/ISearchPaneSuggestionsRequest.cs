namespace Windows.ApplicationModel.Search
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x81b10b1c, 0xe561, 0x4093, 0x9b, 0x4d, 0x2a, 0xd4, 130, 0x79, 0x4a, 0x53), ExclusiveTo(typeof(SearchPaneSuggestionsRequest)), Version(0x6020000)]
    internal interface ISearchPaneSuggestionsRequest
    {
        SearchPaneSuggestionsRequestDeferral GetDeferral();

        bool IsCanceled { get; }

        Windows.ApplicationModel.Search.SearchSuggestionCollection SearchSuggestionCollection { get; }
    }
}

