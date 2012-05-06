namespace Windows.Storage.Streams
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Flags]
    public enum InputStreamOptions : uint
    {
        None = 0,
        Partial = 1,
        ReadAhead = 2
    }
}

