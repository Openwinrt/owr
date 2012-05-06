namespace Windows.Storage.Pickers.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum AddFileResult
    {
        Added,
        AlreadyAdded,
        NotAllowed,
        Unavailable
    }
}

