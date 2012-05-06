namespace Windows.Security.Authentication.Web
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x2f149f1a, 0xe673, 0x40b5, 0xbc, 0x22, 0x20, 0x1a, 0x68, 100, 0xa3, 0x7b), Version(0x6020000), ExclusiveTo(typeof(WebAuthenticationBroker))]
    internal interface IWebAuthenticationBrokerStatics
    {
        [DefaultOverload, Overload("AuthenticateWithoutCallbackUriAsync")]
        IAsyncOperation<WebAuthenticationResult> AuthenticateAsync([In] WebAuthenticationOptions options, [In] Uri requestUri);
        [DefaultOverload, Overload("AuthenticateWithCallbackUriAsync")]
        IAsyncOperation<WebAuthenticationResult> AuthenticateAsync([In] WebAuthenticationOptions options, [In] Uri requestUri, [In] Uri callbackUri);
        Uri GetCurrentApplicationCallbackUri();
    }
}

