namespace Windows.ApplicationModel.Search
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), ExclusiveTo(typeof(SearchSuggestionCollection)), Windows.Foundation.Metadata.Guid(0x323a8a4b, 0xfbea, 0x4446, 0xab, 0xbc, 0x3d, 0xa7, 0x91, 0x5f, 0xdd, 0x3a)]
    internal interface ISearchSuggestionCollection
    {
        void AppendQuerySuggestion([In] string text);
        void AppendQuerySuggestions([In] IIterable<string> suggestions);
        void AppendResultSuggestion([In] string text, [In] string detailText, [In] string tag, [In] IRandomAccessStreamReference image, [In] string imageAlternateText);
        void AppendSearchSeparator([In] string label);

        uint Size { get; }
    }
}

