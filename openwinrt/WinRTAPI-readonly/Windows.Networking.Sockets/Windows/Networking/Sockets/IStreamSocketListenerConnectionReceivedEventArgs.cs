namespace Windows.Networking.Sockets
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(StreamSocketListenerConnectionReceivedEventArgs)), Guid(0xc472ea9, 0x373f, 0x447b, 0x85, 0xb1, 0xdd, 0xd4, 0x54, 0x88, 3, 0xba)]
    internal interface IStreamSocketListenerConnectionReceivedEventArgs
    {
        StreamSocket Socket { get; }
    }
}

