namespace Windows.Storage.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Flags]
    public enum CachedFileOptions : uint
    {
        DenyAccessWhenOffline = 4,
        None = 0,
        RequireUpdateOnAccess = 1,
        UseCachedFileWhenOffline = 2
    }
}

