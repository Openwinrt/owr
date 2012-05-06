namespace Windows.Storage
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Windows.Foundation.Metadata.Guid(0x6d222fd1, 0xe1c6, 0x468e, 0x86, 0x1a, 0x6c, 0x9e, 0x92, 0xd7, 0x34, 0x8a), Version(0x6020000)]
    public interface IStorageFile : IStorageItem, IRandomAccessStreamReference, IInputStreamReference
    {
        IAsyncAction CopyAndReplaceAsync([In] IStorageFile fileToReplace);
        [Overload("CopyOverloadDefaultNameAndOptions")]
        IAsyncOperation<StorageFile> CopyAsync([In] IStorageFolder destinationFolder);
        [Overload("CopyOverloadDefaultOptions")]
        IAsyncOperation<StorageFile> CopyAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName);
        [Overload("CopyOverload")]
        IAsyncOperation<StorageFile> CopyAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName, [In] NameCollisionOption option);
        IAsyncAction MoveAndReplaceAsync([In] IStorageFile fileToReplace);
        [Overload("MoveOverloadDefaultNameAndOptions")]
        IAsyncAction MoveAsync([In] IStorageFolder destinationFolder);
        [Overload("MoveOverloadDefaultOptions")]
        IAsyncAction MoveAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName);
        [Overload("MoveOverload")]
        IAsyncAction MoveAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName, [In] NameCollisionOption option);
        IAsyncOperation<IRandomAccessStream> OpenAsync([In] FileAccessMode accessMode);

        string ContentType { get; }

        string FileType { get; }
    }
}

