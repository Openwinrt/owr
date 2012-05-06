namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Web;

    [DualApiPartition(version=0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IWebSocketErrorStatics), 0x6020000), Threading(ThreadingModel.Both), Version(0x6020000)]
    public static class WebSocketError
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static WebErrorStatus GetStatus([In] int hresult);
    }
}

