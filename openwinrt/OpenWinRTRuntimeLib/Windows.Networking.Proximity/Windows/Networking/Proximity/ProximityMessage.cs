namespace Windows.Networking.Proximity
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [DualApiPartition(version=0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class ProximityMessage : IProximityMessage
    {
        public IBuffer Data { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string DataAsString { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string MessageType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public long SubscriptionId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IBuffer Windows.Networking.Proximity.IProximityMessage.Data { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.Proximity.IProximityMessage.DataAsString { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.Proximity.IProximityMessage.MessageType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public long Windows.Networking.Proximity.IProximityMessage.SubscriptionId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

