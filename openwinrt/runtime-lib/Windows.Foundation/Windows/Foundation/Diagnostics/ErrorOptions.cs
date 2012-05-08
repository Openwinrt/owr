namespace Windows.Foundation.Diagnostics
{
    using System;
    using Windows.Foundation.Metadata;

    [Flags, Version(0x6020000)]
    public enum ErrorOptions : uint
    {
        ForceExceptions = 2,
        None = 0,
        SuppressExceptions = 1,
        SuppressSetErrorInfo = 8,
        UseSetErrorInfo = 4
    }
}

