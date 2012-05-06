namespace Windows.Networking.Sockets
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xe62ba82f, 0xa63a, 0x430b, 0xbf, 0x62, 0x29, 0xe9, 0x3e, 0x56, 0x33, 180), ExclusiveTo(typeof(StreamSocketListenerInformation))]
    internal interface IStreamSocketListenerInformation
    {
        string LocalServiceName { get; }
    }
}

