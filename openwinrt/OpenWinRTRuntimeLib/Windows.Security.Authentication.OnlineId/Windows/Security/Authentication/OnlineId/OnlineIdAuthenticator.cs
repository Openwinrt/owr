namespace Windows.Security.Authentication.OnlineId
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Version(0x6020000), Activatable(0x6020000)]
    public sealed class OnlineIdAuthenticator : IOnlineIdAuthenticator
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public OnlineIdAuthenticator();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AuthenticateUserAsync")]
        public UserAuthenticationOperation AuthenticateUserAsync([In] OnlineIdServiceTicketRequest request, [In] string caption);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AuthenticateUserAsyncAdvanced"), DefaultOverload]
        public UserAuthenticationOperation AuthenticateUserAsync([In] IVectorView<OnlineIdServiceTicketRequest> requests, [In] string caption, [In] CredentialPromptType credentialPromptType);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AuthenticateUserHostAsyncAdvanced"), DefaultOverload]
        public UserHostAuthenticationOperation AuthenticateUserHostAsync([In] IVectorView<OnlineIdServiceTicketRequest> requests);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AuthenticateUserHostAsync")]
        public UserHostAuthenticationOperation AuthenticateUserHostAsync([In] OnlineIdServiceTicketRequest request);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SignOutUserOperation SignOutUserAsync();

        public Guid ApplicationId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Guid Windows.Security.Authentication.OnlineId.IOnlineIdAuthenticator.ApplicationId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

