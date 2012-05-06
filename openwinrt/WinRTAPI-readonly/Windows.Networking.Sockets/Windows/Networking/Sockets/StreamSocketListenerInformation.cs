namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class StreamSocketListenerInformation : IStreamSocketListenerInformation
    {
        public string LocalServiceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.Sockets.IStreamSocketListenerInformation.LocalServiceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

