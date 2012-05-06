namespace Windows.ApplicationModel.Search
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class SearchPaneSuggestionsRequest : ISearchPaneSuggestionsRequest
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SearchPaneSuggestionsRequestDeferral GetDeferral();

        public bool IsCanceled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.ApplicationModel.Search.SearchSuggestionCollection SearchSuggestionCollection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.ApplicationModel.Search.ISearchPaneSuggestionsRequest.IsCanceled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.ApplicationModel.Search.SearchSuggestionCollection Windows.ApplicationModel.Search.ISearchPaneSuggestionsRequest.SearchSuggestionCollection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

