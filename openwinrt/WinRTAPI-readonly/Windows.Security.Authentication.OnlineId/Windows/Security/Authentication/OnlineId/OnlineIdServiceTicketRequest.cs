namespace Windows.Security.Authentication.OnlineId
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Activatable(typeof(IOnlineIdServiceTicketRequestFactory), 0x6020000), Threading(ThreadingModel.Both)]
    public sealed class OnlineIdServiceTicketRequest : IOnlineIdServiceTicketRequest
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public OnlineIdServiceTicketRequest([In] string service);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public OnlineIdServiceTicketRequest([In] string service, [In] string policy);

        public string Policy { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Service { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Authentication.OnlineId.IOnlineIdServiceTicketRequest.Policy { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Authentication.OnlineId.IOnlineIdServiceTicketRequest.Service { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

