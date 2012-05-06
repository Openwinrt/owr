namespace Windows.Networking.Proximity
{
    using Windows.Foundation.Metadata;

    [Guid(0xeb6891ae, 0x4f1e, 0x4c66, 0xbd, 13, 70, 0x92, 0x4a, 0x94, 0x2e, 8), ExclusiveTo(typeof(ConnectionRequestedEventArgs)), Version(0x6020000)]
    internal interface IConnectionRequestedEventArgs
    {
        Windows.Networking.Proximity.PeerInformation PeerInformation { get; }
    }
}

