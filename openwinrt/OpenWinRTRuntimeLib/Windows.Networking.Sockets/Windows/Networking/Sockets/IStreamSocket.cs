namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Networking;
    using Windows.Storage.Streams;

    [Windows.Foundation.Metadata.Guid(0x69a22cf3, 0xfc7b, 0x4857, 0xaf, 0x38, 0xf6, 0xe7, 0xde, 0x6a, 0x5b, 0x49), Version(0x6020000)]
    public interface IStreamSocket : IClosable
    {
        [Overload("ConnectWithEndpointPairAsync")]
        IAsyncAction ConnectAsync([In] EndpointPair endpointPair);
        [Overload("ConnectWithEndpointPairAndProtectionLevelAsync")]
        IAsyncAction ConnectAsync([In] EndpointPair endpointPair, [In] SocketProtectionLevel protectionLevel);
        [Overload("ConnectAsync"), DefaultOverload]
        IAsyncAction ConnectAsync([In] HostName remoteHostName, [In] string remoteServiceName);
        [Overload("ConnectWithProtectionLevelAsync")]
        IAsyncAction ConnectAsync([In] HostName remoteHostName, [In] string remoteServiceName, [In] SocketProtectionLevel protectionLevel);
        IAsyncAction UpgradeToSslAsync([In] SocketProtectionLevel protectionLevel, [In] HostName validationHostName);

        StreamSocketControl Control { get; }

        StreamSocketInformation Information { get; }

        IInputStream InputStream { get; }

        IOutputStream OutputStream { get; }
    }
}

