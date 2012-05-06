namespace Windows.Security.Authentication.Web
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum WebAuthenticationStatus
    {
        Success,
        UserCancel,
        ErrorHttp
    }
}

