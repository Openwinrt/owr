namespace Windows.Security.Authentication.Web
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class WebAuthenticationResult : IWebAuthenticationResult
    {
        public string ResponseData { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint ResponseErrorDetail { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public WebAuthenticationStatus ResponseStatus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Authentication.Web.IWebAuthenticationResult.ResponseData { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Security.Authentication.Web.IWebAuthenticationResult.ResponseErrorDetail { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public WebAuthenticationStatus Windows.Security.Authentication.Web.IWebAuthenticationResult.ResponseStatus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

