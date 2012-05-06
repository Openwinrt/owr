namespace Windows.Security.Authentication.OnlineId
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x297445d3, 0xfb63, 0x4135, 0x89, 9, 0x4e, 0x35, 0x4c, 6, 20, 0x66), ExclusiveTo(typeof(OnlineIdServiceTicketRequest)), Version(0x6020000)]
    internal interface IOnlineIdServiceTicketRequest
    {
        string Policy { get; }

        string Service { get; }
    }
}

