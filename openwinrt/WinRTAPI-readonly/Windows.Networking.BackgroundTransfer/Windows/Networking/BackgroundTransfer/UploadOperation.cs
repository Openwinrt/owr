namespace Windows.Networking.BackgroundTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;
    using Windows.Storage.Streams;

    [Version(0x6020000)]
    public sealed class UploadOperation : IUploadOperation, IBackgroundTransferOperation
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<UploadOperation, UploadOperation> AttachAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ResponseInformation GetResponseInformation();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IInputStream GetResultStreamAt([In] ulong position);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<UploadOperation, UploadOperation> StartAsync();

        public BackgroundTransferCostPolicy CostPolicy { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Group { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public System.Guid Guid { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Method { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public BackgroundUploadProgress Progress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri RequestedUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IStorageFile SourceFile { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public BackgroundTransferCostPolicy Windows.Networking.BackgroundTransfer.IBackgroundTransferOperation.CostPolicy { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Networking.BackgroundTransfer.IBackgroundTransferOperation.Group { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public System.Guid Windows.Networking.BackgroundTransfer.IBackgroundTransferOperation.Guid { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.BackgroundTransfer.IBackgroundTransferOperation.Method { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.Networking.BackgroundTransfer.IBackgroundTransferOperation.RequestedUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public BackgroundUploadProgress Windows.Networking.BackgroundTransfer.IUploadOperation.Progress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IStorageFile Windows.Networking.BackgroundTransfer.IUploadOperation.SourceFile { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

