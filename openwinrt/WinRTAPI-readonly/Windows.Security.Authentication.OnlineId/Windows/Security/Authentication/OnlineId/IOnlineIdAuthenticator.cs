namespace Windows.Security.Authentication.OnlineId
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(OnlineIdAuthenticator)), Windows.Foundation.Metadata.Guid(0xc2f891fc, 0x4d5c, 0x4a63, 170, 0xd7, 0xf4, 0x87, 130, 0xd7, 240, 14), Version(0x6020000)]
    internal interface IOnlineIdAuthenticator
    {
        [Overload("AuthenticateUserAsync")]
        UserAuthenticationOperation AuthenticateUserAsync([In] OnlineIdServiceTicketRequest request, [In] string caption);
        [DefaultOverload, Overload("AuthenticateUserAsyncAdvanced")]
        UserAuthenticationOperation AuthenticateUserAsync([In] IVectorView<OnlineIdServiceTicketRequest> requests, [In] string caption, [In] CredentialPromptType credentialPromptType);
        [DefaultOverload, Overload("AuthenticateUserHostAsyncAdvanced")]
        UserHostAuthenticationOperation AuthenticateUserHostAsync([In] IVectorView<OnlineIdServiceTicketRequest> requests);
        [Overload("AuthenticateUserHostAsync")]
        UserHostAuthenticationOperation AuthenticateUserHostAsync([In] OnlineIdServiceTicketRequest request);
        SignOutUserOperation SignOutUserAsync();

        Guid ApplicationId { get; [param: In] set; }
    }
}

