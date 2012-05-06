namespace Windows.Networking.BackgroundTransfer
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xf2875cfb, 0x9b05, 0x4741, 0x91, 0x21, 0x74, 10, 0x83, 0xe2, 0x47, 0xdf), Version(0x6020000), ExclusiveTo(typeof(BackgroundUploader))]
    internal interface IBackgroundUploaderStaticMethods
    {
        [Overload("GetCurrentUploadsAsync")]
        IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsAsync();
        [Overload("GetCurrentUploadsForGroupAsync")]
        IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsAsync([In] string group);
    }
}

