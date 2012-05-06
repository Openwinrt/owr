namespace Windows.Security.Authentication.OnlineId
{
    using System;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Guid(0x2146d9cd, 0x742, 0x4be3, 0x8a, 0x1c, 0x7c, 0x7a, 230, 0x79, 170, 0x88), Version(0x6020000), ExclusiveTo(typeof(UserIdentity))]
    internal interface IUserIdentity
    {
        string FirstName { get; }

        string Id { get; }

        bool IsBetaAccount { get; }

        bool IsConfirmedPC { get; }

        string LastName { get; }

        string SafeCustomerId { get; }

        string SignInName { get; }

        IVectorView<OnlineIdServiceTicket> Tickets { get; }
    }
}

