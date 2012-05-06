namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(StreamWebSocketControl)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xb4f478b1, 0xa45a, 0x48db, 0x95, 0x3a, 100, 0x5b, 0x7d, 150, 0x4c, 7)]
    internal interface IStreamWebSocketControl : IWebSocketControl
    {
        bool NoDelay { get; [param: In] set; }
    }
}

