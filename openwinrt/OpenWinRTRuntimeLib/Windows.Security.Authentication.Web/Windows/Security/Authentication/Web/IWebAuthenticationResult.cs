namespace Windows.Security.Authentication.Web
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x64002b4b, 0xede9, 0x470a, 0xa5, 0xcd, 3, 0x23, 250, 0xf6, 0xe2, 0x62), ExclusiveTo(typeof(WebAuthenticationResult))]
    internal interface IWebAuthenticationResult
    {
        string ResponseData { get; }

        uint ResponseErrorDetail { get; }

        WebAuthenticationStatus ResponseStatus { get; }
    }
}

