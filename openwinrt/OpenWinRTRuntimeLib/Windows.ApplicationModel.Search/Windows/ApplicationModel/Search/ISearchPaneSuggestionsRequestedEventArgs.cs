namespace Windows.ApplicationModel.Search
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xc89b8a2f, 0xac56, 0x4460, 0x8d, 0x2f, 0x80, 2, 0x3b, 0xec, 0x4f, 0xc5), ExclusiveTo(typeof(SearchPaneSuggestionsRequestedEventArgs))]
    internal interface ISearchPaneSuggestionsRequestedEventArgs : ISearchPaneQueryChangedEventArgs
    {
        SearchPaneSuggestionsRequest Request { get; }
    }
}

