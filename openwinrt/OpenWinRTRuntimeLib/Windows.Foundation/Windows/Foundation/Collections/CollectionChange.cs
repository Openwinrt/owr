namespace Windows.Foundation.Collections
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum CollectionChange
    {
        Reset,
        ItemInserted,
        ItemRemoved,
        ItemChanged
    }
}

