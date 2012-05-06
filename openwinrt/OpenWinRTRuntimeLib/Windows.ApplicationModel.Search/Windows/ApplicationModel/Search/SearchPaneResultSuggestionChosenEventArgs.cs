namespace Windows.ApplicationModel.Search
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class SearchPaneResultSuggestionChosenEventArgs : ISearchPaneResultSuggestionChosenEventArgs
    {
        public string Tag { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Search.ISearchPaneResultSuggestionChosenEventArgs.Tag { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

