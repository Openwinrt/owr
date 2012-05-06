namespace Windows.ApplicationModel.Search
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xa0d009f7, 0x8748, 0x4ee2, 0xad, 0x44, 0xaf, 0xa6, 190, 0x99, 0x7c, 0x51), Version(0x6020000), ExclusiveTo(typeof(SearchPaneSuggestionsRequestDeferral))]
    internal interface ISearchPaneSuggestionsRequestDeferral
    {
        void Complete();
    }
}

