namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.Background;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Version(0x6020000), Threading(ThreadingModel.MTA), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class WebSocketKeepAlive : IBackgroundTask
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public WebSocketKeepAlive();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Run([In] IBackgroundTaskInstance taskInstance);
    }
}

