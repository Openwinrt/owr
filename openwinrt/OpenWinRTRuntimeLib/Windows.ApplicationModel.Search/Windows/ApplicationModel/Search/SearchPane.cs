namespace Windows.ApplicationModel.Search
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(ISearchPaneStatics), 0x6020000)]
    public sealed class SearchPane : ISearchPane
    {
        public event TypedEventHandler<SearchPane, SearchPaneQueryChangedEventArgs> QueryChanged;

        public event TypedEventHandler<SearchPane, SearchPaneQuerySubmittedEventArgs> QuerySubmitted;

        public event TypedEventHandler<SearchPane, SearchPaneResultSuggestionChosenEventArgs> ResultSuggestionChosen;

        public event TypedEventHandler<SearchPane, SearchPaneSuggestionsRequestedEventArgs> SuggestionsRequested;

        public event TypedEventHandler<SearchPane, SearchPaneVisibilityChangedEventArgs> VisibilityChanged;

        public event TypedEventHandler<SearchPane, SearchPaneQueryChangedEventArgs> Windows.ApplicationModel.Search.ISearchPane.QueryChanged;

        public event TypedEventHandler<SearchPane, SearchPaneQuerySubmittedEventArgs> Windows.ApplicationModel.Search.ISearchPane.QuerySubmitted;

        public event TypedEventHandler<SearchPane, SearchPaneResultSuggestionChosenEventArgs> Windows.ApplicationModel.Search.ISearchPane.ResultSuggestionChosen;

        public event TypedEventHandler<SearchPane, SearchPaneSuggestionsRequestedEventArgs> Windows.ApplicationModel.Search.ISearchPane.SuggestionsRequested;

        public event TypedEventHandler<SearchPane, SearchPaneVisibilityChangedEventArgs> Windows.ApplicationModel.Search.ISearchPane.VisibilityChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static SearchPane GetForCurrentView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetLocalContentSuggestionSettings([In] LocalContentSuggestionSettings settings);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ShowOverloadDefault")]
        public void Show();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ShowOverloadWithQuery")]
        public void Show([In] string query);

        public string Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string PlaceholderText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string QueryText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string SearchHistoryContext { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool SearchHistoryEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Visible { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Search.ISearchPane.Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Search.ISearchPane.PlaceholderText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.ApplicationModel.Search.ISearchPane.QueryText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Search.ISearchPane.SearchHistoryContext { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.ApplicationModel.Search.ISearchPane.SearchHistoryEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.ApplicationModel.Search.ISearchPane.Visible { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

