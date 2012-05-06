namespace Windows.Networking.Proximity
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Networking.Sockets;
    using Windows.Storage.Streams;

    [Version(0x6020000), Guid(0xc6a72fda, 0x3947, 0x4eaa, 0x8d, 14, 0xd0, 0x26, 0x1b, 0xb7, 190, 0x48), ExclusiveTo(typeof(ProximityStreamSocket))]
    internal interface IProximityStreamSocket : IStreamSocket, IClosable
    {
        IBuffer SessionKey { get; }

        ProximitySocketType SocketType { get; }
    }
}

