namespace Windows.ApplicationModel.Search
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x3c4d3046, 0xac4b, 0x49f2, 0x97, 0xd6, 2, 14, 0x61, 130, 0xcb, 0x9c), Version(0x6020000), ExclusiveTo(typeof(SearchPaneVisibilityChangedEventArgs))]
    internal interface ISearchPaneVisibilityChangedEventArgs
    {
        bool Visible { get; }
    }
}

