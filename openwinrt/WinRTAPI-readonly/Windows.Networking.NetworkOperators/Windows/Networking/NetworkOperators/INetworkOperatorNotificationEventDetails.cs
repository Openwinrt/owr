namespace Windows.Networking.NetworkOperators
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xbc68a9d1, 0x82e1, 0x4488, 0x9f, 0x2c, 0x12, 0x76, 0xc2, 70, 0x8f, 0xac), ExclusiveTo(typeof(NetworkOperatorNotificationEventDetails)), Version(0x6020000)]
    internal interface INetworkOperatorNotificationEventDetails
    {
        byte EncodingType { get; }

        string Message { get; }

        string NetworkAccountId { get; }

        NetworkOperatorEventMessageType NotificationType { get; }
    }
}

