namespace Windows.Networking.Proximity
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(ProximityMessage)), Guid(0xefab0782, 0xf6e1, 0x4675, 160, 0x45, 0xd8, 0xe3, 0x20, 0xc2, 0x48, 8), Version(0x6020000)]
    internal interface IProximityMessage
    {
        IBuffer Data { get; }

        string DataAsString { get; }

        string MessageType { get; }

        long SubscriptionId { get; }
    }
}

