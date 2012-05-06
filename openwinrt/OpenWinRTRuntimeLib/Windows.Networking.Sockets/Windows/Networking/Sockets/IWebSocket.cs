namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xf877396f, 0x99b1, 0x4e18, 0xbc, 8, 0x85, 12, 0x9a, 0xdf, 0x15, 110)]
    public interface IWebSocket : IClosable
    {
        event TypedEventHandler<IWebSocket, WebSocketClosedEventArgs> Closed;

        [Overload("CloseWithStatus")]
        void Close([In] ushort code, [In] string reason);
        IAsyncAction ConnectAsync([In] Uri uri);
        void SetRequestHeader([In] string headerName, [In] string headerValue);

        IOutputStream OutputStream { get; }
    }
}

