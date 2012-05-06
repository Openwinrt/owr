namespace Windows.Security.Authentication.OnlineId
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(OnlineIdServiceTicketRequest)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xbebb0a08, 0x9e73, 0x4077, 150, 20, 8, 0x61, 0x4c, 11, 0xc2, 0x45)]
    internal interface IOnlineIdServiceTicketRequestFactory
    {
        [Overload("CreateOnlineIdServiceTicketRequestAdvanced"), DefaultOverload]
        OnlineIdServiceTicketRequest CreateOnlineIdServiceTicketRequest([In] string service);
        [Overload("CreateOnlineIdServiceTicketRequest")]
        OnlineIdServiceTicketRequest CreateOnlineIdServiceTicketRequest([In] string service, [In] string policy);
    }
}

