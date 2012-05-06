namespace Windows.Networking.Sockets
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.Networking;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(DatagramSocketMessageReceivedEventArgs)), Version(0x6020000), Guid(0x9e2ddca2, 0x1712, 0x4ce4, 0xb1, 0x79, 140, 0x65, 0x2c, 0x6d, 0x10, 0x7e)]
    internal interface IDatagramSocketMessageReceivedEventArgs
    {
        DataReader GetDataReader();
        IInputStream GetDataStream();

        HostName LocalHostName { get; }

        HostName RemoteHostName { get; }

        string RemoteServiceName { get; }
    }
}

