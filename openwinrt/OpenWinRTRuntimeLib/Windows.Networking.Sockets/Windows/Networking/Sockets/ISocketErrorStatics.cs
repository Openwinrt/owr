namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x828337f4, 0x7d56, 0x4d8e, 0xb7, 180, 160, 0x7d, 0xd7, 0xc1, 0xbc, 0xa9), Version(0x6020000), ExclusiveTo(typeof(SocketError))]
    internal interface ISocketErrorStatics
    {
        SocketErrorStatus GetStatus([In] int hresult);
    }
}

