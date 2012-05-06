namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.Networking;

    [DualApiPartition(version=0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class DatagramSocketInformation : IDatagramSocketInformation
    {
        public HostName LocalHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string LocalServiceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HostName RemoteHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string RemoteServiceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HostName Windows.Networking.Sockets.IDatagramSocketInformation.LocalHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.Sockets.IDatagramSocketInformation.LocalServiceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HostName Windows.Networking.Sockets.IDatagramSocketInformation.RemoteHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.Sockets.IDatagramSocketInformation.RemoteServiceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

