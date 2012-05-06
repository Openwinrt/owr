namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x112fbfc8, 0xf235, 0x4fde, 0x8d, 0x41, 0x9b, 0xf2, 0x7c, 0x9e, 0x9a, 0x40), ExclusiveTo(typeof(PlayToConnection))]
    internal interface IPlayToConnection
    {
        event TypedEventHandler<PlayToConnection, PlayToConnectionErrorEventArgs> Error;

        event TypedEventHandler<PlayToConnection, PlayToConnectionStateChangedEventArgs> StateChanged;

        event TypedEventHandler<PlayToConnection, PlayToConnectionTransferredEventArgs> Transferred;

        PlayToConnectionState State { get; }
    }
}

