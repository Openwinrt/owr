namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Web;

    [Windows.Foundation.Metadata.Guid(0x27cdf35b, 0x1f61, 0x4709, 0x8e, 2, 0x61, 40, 0x3a, 0xda, 0x4e, 0x9d), Version(0x6020000), ExclusiveTo(typeof(WebSocketError))]
    internal interface IWebSocketErrorStatics
    {
        WebErrorStatus GetStatus([In] int hresult);
    }
}

