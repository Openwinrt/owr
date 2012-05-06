namespace Windows.Storage
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(CachedFileManager)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x8ffc224a, 0xe782, 0x495d, 0xb6, 20, 0x65, 0x4c, 0x4f, 11, 0x23, 0x70)]
    internal interface ICachedFileManagerStatics
    {
        IAsyncOperation<FileUpdateStatus> CompleteUpdatesAsync([In] IStorageFile file);
        void DeferUpdates([In] IStorageFile file);
    }
}

