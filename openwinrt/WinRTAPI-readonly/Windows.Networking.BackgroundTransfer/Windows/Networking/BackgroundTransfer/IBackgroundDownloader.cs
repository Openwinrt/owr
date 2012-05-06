namespace Windows.Networking.BackgroundTransfer
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;
    using Windows.Storage.Streams;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xc1c79333, 0x6649, 0x4b1d, 0xa8, 0x26, 0xa4, 0xb3, 0xdd, 0x23, 0x4d, 11), ExclusiveTo(typeof(BackgroundDownloader))]
    internal interface IBackgroundDownloader : IBackgroundTransferBase
    {
        DownloadOperation CreateDownload([In] Uri uri, [In] IStorageFile resultFile);
        void SetRequestBodyFile([In] IStorageFile value);
        IAsyncAction SetRequestBodyStreamAsync([In] IInputStream sourceStream);
    }
}

