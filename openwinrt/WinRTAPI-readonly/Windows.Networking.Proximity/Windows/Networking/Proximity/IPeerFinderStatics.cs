namespace Windows.Networking.Proximity
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x914b3b61, 0xf6e1, 0x47c4, 0xa1, 0x4c, 20, 0x8a, 0x19, 3, 0xd0, 0xc6), Version(0x6020000), ExclusiveTo(typeof(PeerFinder))]
    internal interface IPeerFinderStatics
    {
        event TypedEventHandler<object, ConnectionRequestedEventArgs> ConnectionRequested;

        event TypedEventHandler<object, TriggeredConnectionStateChangedEventArgs> TriggeredConnectionStateChanged;

        IAsyncOperation<ProximityStreamSocket> ConnectAsync([In] PeerInformation peerInformation);
        IAsyncOperation<IVectorView<PeerInformation>> FindAllPeersAsync();
        [Overload("Start"), DefaultOverload]
        void Start();
        [DefaultOverload, Overload("StartWithMessage")]
        void Start([In] string peerMessage);
        void Stop();

        bool AllowBluetooth { get; [param: In] set; }

        bool AllowTcpIp { get; [param: In] set; }

        bool AllowWiFiDirect { get; [param: In] set; }

        IMap<string, string> AlternateIdentities { get; }

        string DisplayName { get; [param: In] set; }

        PeerDiscoveryTypes SupportedDiscoveryTypes { get; }
    }
}

