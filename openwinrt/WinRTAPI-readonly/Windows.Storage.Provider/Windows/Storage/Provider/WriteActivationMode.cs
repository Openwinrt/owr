namespace Windows.Storage.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum WriteActivationMode
    {
        ReadOnly,
        NotNeeded,
        AfterWrite
    }
}

