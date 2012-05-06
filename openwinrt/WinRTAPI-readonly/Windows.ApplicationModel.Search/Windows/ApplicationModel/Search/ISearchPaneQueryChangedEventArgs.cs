namespace Windows.ApplicationModel.Search
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x3c064fe9, 0x2351, 0x4248, 0xa5, 0x29, 0x71, 0x10, 0xf4, 100, 0xa7, 0x85)]
    public interface ISearchPaneQueryChangedEventArgs
    {
        string Language { get; }

        SearchPaneQueryLinguisticDetails LinguisticDetails { get; }

        string QueryText { get; }
    }
}

