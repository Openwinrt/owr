namespace Windows.Storage.Provider
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Version(0x6020000)]
    public sealed class FileUpdateRequest : IFileUpdateRequest
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public FileUpdateRequestDeferral GetDeferral();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void UpdateLocalFile([In] IStorageFile value);

        public string ContentId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StorageFile File { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public FileUpdateStatus Status { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Storage.Provider.IFileUpdateRequest.ContentId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StorageFile Windows.Storage.Provider.IFileUpdateRequest.File { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public FileUpdateStatus Windows.Storage.Provider.IFileUpdateRequest.Status { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

