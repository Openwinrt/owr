namespace Windows.ApplicationModel.Search
{
    using System;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Guid(0x82fb460e, 0x940, 0x4b6d, 0xb8, 0xd0, 100, 0x2b, 0x30, 0x98, 0x9e, 0x15), ExclusiveTo(typeof(SearchPaneQueryLinguisticDetails)), Version(0x6020000)]
    internal interface ISearchPaneQueryLinguisticDetails
    {
        IVectorView<string> QueryTextAlternatives { get; }

        uint QueryTextCompositionLength { get; }

        uint QueryTextCompositionStart { get; }
    }
}

