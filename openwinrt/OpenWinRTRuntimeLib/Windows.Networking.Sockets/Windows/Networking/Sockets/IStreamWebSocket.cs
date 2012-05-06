namespace Windows.Networking.Sockets
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(StreamWebSocket)), Version(0x6020000), Guid(0xbd4a49d8, 0xb289, 0x45bb, 0x97, 0xeb, 0xc7, 0x52, 0x52, 5, 0xa8, 0x43)]
    internal interface IStreamWebSocket : IWebSocket, IClosable
    {
        StreamWebSocketControl Control { get; }

        StreamWebSocketInformation Information { get; }

        IInputStream InputStream { get; }
    }
}

