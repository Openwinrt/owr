namespace Windows.Security.Authentication.OnlineId
{
    using System;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x79882e54, 0xc2ae, 0x4f76, 0x95, 0x77, 0x9f, 0xe0, 40, 180, 130, 0x55), ExclusiveTo(typeof(UserHostIdentity))]
    internal interface IUserHostIdentity
    {
        string Id { get; }

        IVectorView<OnlineIdServiceTicket> Tickets { get; }
    }
}

