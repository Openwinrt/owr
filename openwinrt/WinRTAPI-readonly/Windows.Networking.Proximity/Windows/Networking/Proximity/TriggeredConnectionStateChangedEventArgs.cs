namespace Windows.Networking.Proximity
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class TriggeredConnectionStateChangedEventArgs : ITriggeredConnectionStateChangedEventArgs
    {
        public uint Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ProximityStreamSocket Socket { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TriggeredConnectState State { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Networking.Proximity.ITriggeredConnectionStateChangedEventArgs.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ProximityStreamSocket Windows.Networking.Proximity.ITriggeredConnectionStateChangedEventArgs.Socket { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TriggeredConnectState Windows.Networking.Proximity.ITriggeredConnectionStateChangedEventArgs.State { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

