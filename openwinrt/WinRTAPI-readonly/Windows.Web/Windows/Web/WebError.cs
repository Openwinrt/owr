namespace Windows.Web
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000), Static(typeof(IWebErrorStatics), 0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public static class WebError
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static WebErrorStatus GetStatus([In] int hresult);
    }
}

