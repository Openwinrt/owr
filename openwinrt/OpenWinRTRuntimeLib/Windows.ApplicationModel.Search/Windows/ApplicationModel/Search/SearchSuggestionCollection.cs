namespace Windows.ApplicationModel.Search
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000)]
    public sealed class SearchSuggestionCollection : ISearchSuggestionCollection
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AppendQuerySuggestion([In] string text);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AppendQuerySuggestions([In] IIterable<string> suggestions);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AppendResultSuggestion([In] string text, [In] string detailText, [In] string tag, [In] IRandomAccessStreamReference image, [In] string imageAlternateText);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AppendSearchSeparator([In] string label);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.ApplicationModel.Search.ISearchSuggestionCollection.Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

