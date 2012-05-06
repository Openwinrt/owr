namespace Windows.Networking.BackgroundTransfer
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Guid(0xbd87ebb0, 0x5714, 0x4e09, 0xba, 0x68, 190, 0xf7, 0x39, 3, 0xb0, 0xd7), Version(0x6020000), ExclusiveTo(typeof(DownloadOperation))]
    internal interface IDownloadOperation : IBackgroundTransferOperation
    {
        IAsyncOperationWithProgress<DownloadOperation, DownloadOperation> AttachAsync();
        void Pause();
        void Resume();
        IAsyncOperationWithProgress<DownloadOperation, DownloadOperation> StartAsync();

        BackgroundDownloadProgress Progress { get; }

        IStorageFile ResultFile { get; }
    }
}

