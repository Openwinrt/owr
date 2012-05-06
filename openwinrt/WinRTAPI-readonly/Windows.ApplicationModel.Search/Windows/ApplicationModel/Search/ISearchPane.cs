namespace Windows.ApplicationModel.Search
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(SearchPane)), Windows.Foundation.Metadata.Guid(0xfdacec38, 0x3700, 0x4d73, 0x91, 0xa1, 0x2f, 0x99, 0x86, 0x74, 0x23, 0x8a)]
    internal interface ISearchPane
    {
        event TypedEventHandler<SearchPane, SearchPaneQueryChangedEventArgs> QueryChanged;

        event TypedEventHandler<SearchPane, SearchPaneQuerySubmittedEventArgs> QuerySubmitted;

        event TypedEventHandler<SearchPane, SearchPaneResultSuggestionChosenEventArgs> ResultSuggestionChosen;

        event TypedEventHandler<SearchPane, SearchPaneSuggestionsRequestedEventArgs> SuggestionsRequested;

        event TypedEventHandler<SearchPane, SearchPaneVisibilityChangedEventArgs> VisibilityChanged;

        void SetLocalContentSuggestionSettings([In] LocalContentSuggestionSettings settings);
        [Overload("ShowOverloadDefault")]
        void Show();
        [Overload("ShowOverloadWithQuery")]
        void Show([In] string query);

        string Language { get; }

        string PlaceholderText { get; [param: In] set; }

        string QueryText { get; }

        string SearchHistoryContext { get; [param: In] set; }

        bool SearchHistoryEnabled { get; [param: In] set; }

        bool Visible { get; }
    }
}

