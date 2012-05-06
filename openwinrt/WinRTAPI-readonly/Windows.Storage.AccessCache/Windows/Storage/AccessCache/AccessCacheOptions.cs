namespace Windows.Storage.AccessCache
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Flags]
    public enum AccessCacheOptions : uint
    {
        DisallowUserInput = 1,
        FastLocationsOnly = 2,
        None = 0,
        SuppressAccessTimeUpdate = 8,
        UseReadOnlyCachedCopy = 4
    }
}

