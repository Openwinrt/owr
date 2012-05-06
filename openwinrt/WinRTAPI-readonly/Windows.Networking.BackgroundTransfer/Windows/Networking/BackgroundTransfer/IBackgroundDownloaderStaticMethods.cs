namespace Windows.Networking.BackgroundTransfer
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(BackgroundDownloader)), Windows.Foundation.Metadata.Guid(0x52a65a35, 0xc64e, 0x426c, 0x99, 0x19, 0x54, 13, 13, 0x21, 0xa6, 80), Version(0x6020000)]
    internal interface IBackgroundDownloaderStaticMethods
    {
        [Overload("GetCurrentDownloadsAsync")]
        IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsAsync();
        [Overload("GetCurrentDownloadsForGroupAsync")]
        IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsAsync([In] string group);
    }
}

