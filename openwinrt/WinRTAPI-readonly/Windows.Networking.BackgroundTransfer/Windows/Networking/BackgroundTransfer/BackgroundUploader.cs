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

    [Activatable(0x6020000), Version(0x6020000), Static(typeof(IBackgroundUploaderStaticMethods), 0x6020000), Threading(ThreadingModel.MTA)]
    public sealed class BackgroundUploader : IBackgroundUploader, IBackgroundTransferBase
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public BackgroundUploader();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateUpload")]
        public UploadOperation CreateUpload([In] Uri uri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateUploadForFile")]
        public UploadOperation CreateUpload([In] Uri uri, [In] IStorageFile sourceFile);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetCurrentUploadsAsync")]
        public static IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetCurrentUploadsForGroupAsync")]
        public static IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsAsync([In] string group);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetRequestHeader([In] string headerName, [In] string headerValue);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetSourceFile([In] IStorageFile value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction SetSourceStreamAsync([In] IInputStream sourceStream);

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

