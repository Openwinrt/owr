namespace Windows.Security.Authentication.OnlineId
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class UserIdentity : IUserIdentity
    {
        public string FirstName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsBetaAccount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsConfirmedPC { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string LastName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string SafeCustomerId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string SignInName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<OnlineIdServiceTicket> Tickets { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Authentication.OnlineId.IUserIdentity.FirstName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Authentication.OnlineId.IUserIdentity.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Security.Authentication.OnlineId.IUserIdentity.IsBetaAccount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Security.Authentication.OnlineId.IUserIdentity.IsConfirmedPC { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Authentication.OnlineId.IUserIdentity.LastName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Authentication.OnlineId.IUserIdentity.SafeCustomerId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Authentication.OnlineId.IUserIdentity.SignInName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<OnlineIdServiceTicket> Windows.Security.Authentication.OnlineId.IUserIdentity.Tickets { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

