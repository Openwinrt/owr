namespace Windows.Storage.Pickers.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum SetFileNameResult
    {
        Succeeded,
        NotAllowed,
        Unavailable
    }
}

