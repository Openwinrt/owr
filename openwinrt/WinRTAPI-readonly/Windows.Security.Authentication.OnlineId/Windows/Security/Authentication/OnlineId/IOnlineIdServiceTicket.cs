namespace Windows.Security.Authentication.OnlineId
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xc95c547f, 0xd781, 0x4a94, 0xac, 0xb8, 0xc5, 0x98, 0x74, 0x23, 140, 0x26), ExclusiveTo(typeof(OnlineIdServiceTicket))]
    internal interface IOnlineIdServiceTicket
    {
        int ErrorCode { get; }

        OnlineIdServiceTicketRequest Request { get; }

        string Value { get; }
    }
}

