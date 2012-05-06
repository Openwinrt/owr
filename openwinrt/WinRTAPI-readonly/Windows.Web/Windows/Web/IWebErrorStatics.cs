namespace Windows.Web
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xfe616766, 0xbf27, 0x4064, 0x87, 0xb7, 0x65, 0x63, 0xbb, 0x11, 0xce, 0x2e), ExclusiveTo(typeof(WebError))]
    internal interface IWebErrorStatics
    {
        WebErrorStatus GetStatus([In] int hresult);
    }
}

