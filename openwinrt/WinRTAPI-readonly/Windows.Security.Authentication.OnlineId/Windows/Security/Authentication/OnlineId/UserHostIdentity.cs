namespace Windows.Security.Authentication.OnlineId
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class UserHostIdentity : IUserHostIdentity
    {
        public string Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<OnlineIdServiceTicket> Tickets { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Authentication.OnlineId.IUserHostIdentity.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<OnlineIdServiceTicket> Windows.Security.Authentication.OnlineId.IUserHostIdentity.Tickets { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

