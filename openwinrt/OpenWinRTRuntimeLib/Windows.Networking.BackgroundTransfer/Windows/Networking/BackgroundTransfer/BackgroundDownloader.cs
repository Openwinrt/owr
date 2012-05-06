namespace Windows.Networking.BackgroundTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Security.Credentials;
    using Windows.Storage;
    using Windows.Storage.Streams;

    [Version(0x6020000), Threading(ThreadingModel.MTA), Static(typeof(IBackgroundDownloaderStaticMethods), 0x6020000), Activatable(0x6020000)]
    public sealed class BackgroundDownloader : IBackgroundDownloader, IBackgroundTransferBase
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public BackgroundDownloader();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DownloadOperation CreateDownload([In] Uri uri, [In] IStorageFile resultFile);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetCurrentDownloadsAsync")]
        public static IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetCurrentDownloadsForGroupAsync")]
        public static IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsAsync([In] string group);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetRequestBodyFile([In] IStorageFile value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction SetRequestBodyStreamAsync([In] IInputStream sourceStream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetRequestHeader([In] string headerName, [In] string headerValue);

        public BackgroundTransferCostPolicy CostPolicy { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Group { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Method { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PasswordCredential ProxyCredential { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PasswordCredential ServerCredential { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public BackgroundTransferCostPolicy Windows.Networking.BackgroundTransfer.IBackgroundTransferBase.CostPolicy { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Networking.BackgroundTransfer.IBackgroundTransferBase.Group { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Networking.BackgroundTransfer.IBackgroundTransferBase.Method { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PasswordCredential Windows.Networking.BackgroundTransfer.IBackgroundTransferBase.ProxyCredential { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PasswordCredential Windows.Networking.BackgroundTransfer.IBackgroundTransferBase.ServerCredential { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

