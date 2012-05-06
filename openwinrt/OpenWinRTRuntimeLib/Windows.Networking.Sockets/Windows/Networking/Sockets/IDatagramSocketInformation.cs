namespace Windows.Networking.Sockets
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.Networking;

    [Version(0x6020000), ExclusiveTo(typeof(DatagramSocketInformation)), Guid(0x5f1a569a, 0x55fb, 0x48cd, 0x97, 6, 0x7a, 0x97, 0x4f, 0x7b, 0x15, 0x85)]
    internal interface IDatagramSocketInformation
    {
        HostName LocalHostName { get; }

        string LocalServiceName { get; }

        HostName RemoteHostName { get; }

        string RemoteServiceName { get; }
    }
}

