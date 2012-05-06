namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class NetworkOperatorNotificationEventDetails : INetworkOperatorNotificationEventDetails
    {
        public byte EncodingType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Message { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string NetworkAccountId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public NetworkOperatorEventMessageType NotificationType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public byte Windows.Networking.NetworkOperators.INetworkOperatorNotificationEventDetails.EncodingType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.NetworkOperators.INetworkOperatorNotificationEventDetails.Message { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.NetworkOperators.INetworkOperatorNotificationEventDetails.NetworkAccountId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public NetworkOperatorEventMessageType Windows.Networking.NetworkOperators.INetworkOperatorNotificationEventDetails.NotificationType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

