namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Version(0x6020000), Static(typeof(ISyndicationErrorStatics), 0x6020000), DualApiPartition(version=0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public static class SyndicationError
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static SyndicationErrorStatus GetStatus([In] int hresult);
    }
}

