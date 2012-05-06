namespace Windows.Networking.BackgroundTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Web;

    [Version(0x6020000), Threading(ThreadingModel.Both), Static(typeof(IBackgroundTransferErrorStaticMethods), 0x6020000)]
    public static class BackgroundTransferError
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static WebErrorStatus GetStatus([In] int hresult);
    }
}

