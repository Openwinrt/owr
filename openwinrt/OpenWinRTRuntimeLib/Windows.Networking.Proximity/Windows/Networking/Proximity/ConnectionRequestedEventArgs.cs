namespace Windows.Networking.Proximity
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class ConnectionRequestedEventArgs : IConnectionRequestedEventArgs
    {
        public Windows.Networking.Proximity.PeerInformation PeerInformation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Proximity.PeerInformation Windows.Networking.Proximity.IConnectionRequestedEventArgs.PeerInformation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

