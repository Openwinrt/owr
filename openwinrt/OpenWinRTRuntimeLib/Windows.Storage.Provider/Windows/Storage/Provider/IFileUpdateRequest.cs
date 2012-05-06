namespace Windows.Storage.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Windows.Foundation.Metadata.Guid(0x40c82536, 0xc1fe, 0x4d93, 0xa7, 0x92, 30, 0x73, 0x6b, 0xc7, 8, 0x37), Version(0x6020000), ExclusiveTo(typeof(FileUpdateRequest))]
    internal interface IFileUpdateRequest
    {
        FileUpdateRequestDeferral GetDeferral();
        void UpdateLocalFile([In] IStorageFile value);

        string ContentId { get; }

        StorageFile File { get; }

        FileUpdateStatus Status { get; [param: In] set; }
    }
}

