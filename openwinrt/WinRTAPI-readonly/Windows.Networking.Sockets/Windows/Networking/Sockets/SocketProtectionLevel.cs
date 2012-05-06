namespace Windows.Networking.Sockets
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum SocketProtectionLevel
    {
        PlainSocket,
        Ssl,
        SslAllowNullEncryption
    }
}

