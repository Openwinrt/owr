namespace Windows.ApplicationModel.Search
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x143ba4fc, 0xe9c5, 0x4736, 0x91, 0xb2, 0xe8, 0xeb, 0x9c, 0xb8, 0x83, 0x56), Version(0x6020000), ExclusiveTo(typeof(SearchPaneQuerySubmittedEventArgs))]
    internal interface ISearchPaneQuerySubmittedEventArgs
    {
        string Language { get; }

        string QueryText { get; }
    }
}

