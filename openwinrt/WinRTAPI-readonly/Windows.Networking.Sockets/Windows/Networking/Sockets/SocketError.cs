namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Static(typeof(ISocketErrorStatics), 0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public static class SocketError
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static SocketErrorStatus GetStatus([In] int hresult);
    }
}

