namespace Windows.Networking.Proximity
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.MTA), Version(0x6020000), Static(typeof(IPeerFinderStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public static class PeerFinder
    {
        public static  event TypedEventHandler<object, ConnectionRequestedEventArgs> ConnectionRequested;

        public static  event TypedEventHandler<object, TriggeredConnectionStateChangedEventArgs> TriggeredConnectionStateChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<ProximityStreamSocket> ConnectAsync([In] PeerInformation peerInformation);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<IVectorView<PeerInformation>> FindAllPeersAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("Start"), DefaultOverload]
        public static void Start();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("StartWithMessage")]
        public static void Start([In] string peerMessage);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void Stop();

        public static bool AllowBluetooth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static bool AllowTcpIp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static bool AllowWiFiDirect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static IMap<string, string> AlternateIdentities { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string DisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static PeerDiscoveryTypes SupportedDiscoveryTypes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

