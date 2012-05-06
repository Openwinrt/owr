namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DatagramSocketControl)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x52ac3f2e, 0x349a, 0x4135, 0xbb, 0x58, 0xb7, 0x9b, 0x26, 0x47, 0xd3, 0x90)]
    internal interface IDatagramSocketControl
    {
        SocketQualityOfService QualityOfService { get; [param: In] set; }
    }
}

