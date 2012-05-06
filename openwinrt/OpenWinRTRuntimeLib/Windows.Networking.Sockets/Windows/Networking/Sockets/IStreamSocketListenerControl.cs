namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x20d8c576, 0x8d8a, 0x4dba, 0x97, 0x22, 0xa1, 0x6c, 0x4d, 0x98, 0x49, 0x80), ExclusiveTo(typeof(StreamSocketListenerControl))]
    internal interface IStreamSocketListenerControl
    {
        SocketQualityOfService QualityOfService { get; [param: In] set; }
    }
}

