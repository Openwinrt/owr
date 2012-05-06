namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Security.Credentials;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x2ec4bdc3, 0xd9a5, 0x455a, 0x98, 0x11, 0xde, 0x24, 0xd4, 0x53, 0x37, 0xe9)]
    public interface IWebSocketControl
    {
        uint OutboundBufferSizeInBytes { get; [param: In] set; }

        PasswordCredential ProxyCredential { get; [param: In] set; }

        PasswordCredential ServerCredential { get; [param: In] set; }

        IVector<string> SupportedProtocols { get; }
    }
}

