namespace Windows.Networking.BackgroundTransfer
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(BackgroundUploader)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xc595c9ae, 0xcead, 0x465b, 0x88, 1, 0xc5, 90, 0xc9, 10, 1, 0xce)]
    internal interface IBackgroundUploader : IBackgroundTransferBase
    {
        [Overload("CreateUpload")]
        UploadOperation CreateUpload([In] Uri uri);
        [Overload("CreateUploadForFile")]
        UploadOperation CreateUpload([In] Uri uri, [In] IStorageFile sourceFile);
        void SetSourceFile([In] IStorageFile value);
        IAsyncAction SetSourceStreamAsync([In] IInputStream sourceStream);
    }
}

