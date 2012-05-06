namespace Windows.ApplicationModel.Search
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class SearchPaneSuggestionsRequestedEventArgs : ISearchPaneSuggestionsRequestedEventArgs, ISearchPaneQueryChangedEventArgs
    {
        public string Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SearchPaneQueryLinguisticDetails LinguisticDetails { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string QueryText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SearchPaneSuggestionsRequest Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Search.ISearchPaneQueryChangedEventArgs.Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SearchPaneQueryLinguisticDetails Windows.ApplicationModel.Search.ISearchPaneQueryChangedEventArgs.LinguisticDetails { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Search.ISearchPaneQueryChangedEventArgs.QueryText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SearchPaneSuggestionsRequest Windows.ApplicationModel.Search.ISearchPaneSuggestionsRequestedEventArgs.Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

