namespace Windows.Storage
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x8f327ff, 0x85d5, 0x48b9, 0xae, 0xe9, 40, 0x51, 30, 0x33, 0x9f, 0x9f), ExclusiveTo(typeof(StorageFolder))]
    internal interface IStorageFolderStatics
    {
        IAsyncOperation<StorageFolder> GetFolderFromPathAsync([In] string path);
    }
}

