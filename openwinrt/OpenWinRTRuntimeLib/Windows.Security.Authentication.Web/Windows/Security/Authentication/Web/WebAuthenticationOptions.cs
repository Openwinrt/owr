namespace Windows.Security.Authentication.Web
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Flags]
    public enum WebAuthenticationOptions : uint
    {
        None = 0,
        SilentMode = 1,
        UseTitle = 2
    }
}

