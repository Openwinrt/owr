namespace Windows.Networking.BackgroundTransfer
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Guid(0x3e5624e0, 0x7389, 0x434c, 0x8b, 0x35, 0x42, 0x7f, 0xd3, 0x6b, 0xbd, 0xae), Version(0x6020000), ExclusiveTo(typeof(UploadOperation))]
    internal interface IUploadOperation : IBackgroundTransferOperation
    {
        IAsyncOperationWithProgress<UploadOperation, UploadOperation> AttachAsync();
        IAsyncOperationWithProgress<UploadOperation, UploadOperation> StartAsync();

        BackgroundUploadProgress Progress { get; }

        IStorageFile SourceFile { get; }
    }
}

