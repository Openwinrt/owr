namespace Windows.ApplicationModel.Search
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class SearchPaneVisibilityChangedEventArgs : ISearchPaneVisibilityChangedEventArgs
    {
        public bool Visible { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.ApplicationModel.Search.ISearchPaneVisibilityChangedEventArgs.Visible { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

