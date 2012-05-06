namespace Windows.Security.Authentication.Web
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Static(typeof(IWebAuthenticationBrokerStatics), 0x6020000), Version(0x6020000), Threading(ThreadingModel.Both)]
    public static class WebAuthenticationBroker
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AuthenticateWithoutCallbackUriAsync"), DefaultOverload]
        public static IAsyncOperation<WebAuthenticationResult> AuthenticateAsync([In] WebAuthenticationOptions options, [In] Uri requestUri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AuthenticateWithCallbackUriAsync"), DefaultOverload]
        public static IAsyncOperation<WebAuthenticationResult> AuthenticateAsync([In] WebAuthenticationOptions options, [In] Uri requestUri, [In] Uri callbackUri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Uri GetCurrentApplicationCallbackUri();
    }
}

