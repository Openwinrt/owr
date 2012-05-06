namespace Windows.ApplicationModel.Search
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class SearchPaneQuerySubmittedEventArgs : ISearchPaneQuerySubmittedEventArgs
    {
        public string Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string QueryText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Search.ISearchPaneQuerySubmittedEventArgs.Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Search.ISearchPaneQuerySubmittedEventArgs.QueryText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

