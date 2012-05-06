namespace Windows.Storage.Search
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum IndexerOption
    {
        UseIndexerWhenAvailable,
        OnlyUseIndexer,
        DoNotUseIndexer
    }
}

