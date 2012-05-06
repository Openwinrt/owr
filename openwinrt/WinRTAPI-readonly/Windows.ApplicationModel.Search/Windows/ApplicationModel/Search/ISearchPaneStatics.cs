namespace Windows.ApplicationModel.Search
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x9572adf1, 0x8f1d, 0x481f, 0xa1, 0x5b, 0xc6, 0x16, 0x55, 0xf1, 0x6a, 14), ExclusiveTo(typeof(SearchPane))]
    internal interface ISearchPaneStatics
    {
        SearchPane GetForCurrentView();
    }
}

