namespace Windows.Networking.BackgroundTransfer
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Web;

    [ExclusiveTo(typeof(BackgroundTransferError)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xaad33b04, 0x1192, 0x4bf4, 0x8b, 0x68, 0x39, 0xc5, 0xad, 210, 0x44, 0xe2)]
    internal interface IBackgroundTransferErrorStaticMethods
    {
        WebErrorStatus GetStatus([In] int hresult);
    }
}

