namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xfe25adf1, 0x92ab, 0x4af3, 0x99, 0x92, 15, 0x4c, 0x85, 0xe3, 0x6c, 0xc4), Version(0x6020000), ExclusiveTo(typeof(StreamSocketControl))]
    internal interface IStreamSocketControl
    {
        bool KeepAlive { get; [param: In] set; }

        bool NoDelay { get; [param: In] set; }

        uint OutboundBufferSizeInBytes { get; [param: In] set; }

        SocketQualityOfService QualityOfService { get; [param: In] set; }
    }
}

