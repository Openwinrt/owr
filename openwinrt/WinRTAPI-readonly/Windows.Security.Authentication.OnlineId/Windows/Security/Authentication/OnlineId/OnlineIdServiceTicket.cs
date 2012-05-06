namespace Windows.Security.Authentication.OnlineId
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class OnlineIdServiceTicket : IOnlineIdServiceTicket
    {
        public int ErrorCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public OnlineIdServiceTicketRequest Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Security.Authentication.OnlineId.IOnlineIdServiceTicket.ErrorCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public OnlineIdServiceTicketRequest Windows.Security.Authentication.OnlineId.IOnlineIdServiceTicket.Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Authentication.OnlineId.IOnlineIdServiceTicket.Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

