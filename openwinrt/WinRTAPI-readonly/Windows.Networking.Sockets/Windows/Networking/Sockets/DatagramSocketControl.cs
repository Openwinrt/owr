namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), DualApiPartition(version=0x6020000)]
    public sealed class DatagramSocketControl : IDatagramSocketControl
    {
        public SocketQualityOfService QualityOfService { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public SocketQualityOfService Windows.Networking.Sockets.IDatagramSocketControl.QualityOfService { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

