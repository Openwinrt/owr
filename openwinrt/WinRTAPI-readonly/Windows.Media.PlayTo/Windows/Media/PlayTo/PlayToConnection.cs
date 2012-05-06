namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class PlayToConnection : IPlayToConnection
    {
        public event TypedEventHandler<PlayToConnection, PlayToConnectionErrorEventArgs> Error;

        public event TypedEventHandler<PlayToConnection, PlayToConnectionStateChangedEventArgs> StateChanged;

        public event TypedEventHandler<PlayToConnection, PlayToConnectionTransferredEventArgs> Transferred;

        public event TypedEventHandler<PlayToConnection, PlayToConnectionErrorEventArgs> Windows.Media.PlayTo.IPlayToConnection.Error;

        public event TypedEventHandler<PlayToConnection, PlayToConnectionStateChangedEventArgs> Windows.Media.PlayTo.IPlayToConnection.StateChanged;

        public event TypedEventHandler<PlayToConnection, PlayToConnectionTransferredEventArgs> Windows.Media.PlayTo.IPlayToConnection.Transferred;

        public PlayToConnectionState State { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PlayToConnectionState Windows.Media.PlayTo.IPlayToConnection.State { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

