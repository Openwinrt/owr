namespace Windows.Networking.Sockets
{
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), ExclusiveTo(typeof(MessageWebSocketMessageReceivedEventArgs)), Guid(0x478c22ac, 0x4c4b, 0x42ed, 0x9e, 0xd7, 30, 0xf9, 0xf9, 0x4f, 0xa3, 0xd5)]
    internal interface IMessageWebSocketMessageReceivedEventArgs
    {
        DataReader GetDataReader();
        IInputStream GetDataStream();

        SocketMessageType MessageType { get; }
    }
}

