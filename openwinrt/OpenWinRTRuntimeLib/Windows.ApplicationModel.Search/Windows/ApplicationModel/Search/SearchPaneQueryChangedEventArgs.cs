namespace Windows.ApplicationModel.Search
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class SearchPaneQueryChangedEventArgs : ISearchPaneQueryChangedEventArgs
    {
        public string Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SearchPaneQueryLinguisticDetails LinguisticDetails { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string QueryText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Search.ISearchPaneQueryChangedEventArgs.Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SearchPaneQueryLinguisticDetails Windows.ApplicationModel.Search.ISearchPaneQueryChangedEventArgs.LinguisticDetails { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Search.ISearchPaneQueryChangedEventArgs.QueryText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

