namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.Networking;
    using Windows.Storage.Streams;

    [DualApiPartition(version=0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class DatagramSocketMessageReceivedEventArgs : IDatagramSocketMessageReceivedEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataReader GetDataReader();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IInputStream GetDataStream();

        public HostName LocalHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HostName RemoteHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string RemoteServiceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HostName Windows.Networking.Sockets.IDatagramSocketMessageReceivedEventArgs.LocalHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HostName Windows.Networking.Sockets.IDatagramSocketMessageReceivedEventArgs.RemoteHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.Sockets.IDatagramSocketMessageReceivedEventArgs.RemoteServiceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

