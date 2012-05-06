namespace Windows.Storage
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x4207a996, 0xca2f, 0x42f7, 0xbd, 0xe8, 0x8b, 0x10, 0x45, 0x7a, 0x7f, 0x30)]
    public interface IStorageItem
    {
        [Overload("DeleteAsyncOverloadDefaultOptions")]
        IAsyncAction DeleteAsync();
        [Overload("DeleteAsync")]
        IAsyncAction DeleteAsync([In] StorageDeleteOption option);
        IAsyncOperation<BasicProperties> GetBasicPropertiesAsync();
        bool IsOfType([In] StorageItemTypes type);
        [Overload("RenameAsyncOverloadDefaultOptions")]
        IAsyncAction RenameAsync([In] string desiredName);
        [Overload("RenameAsync")]
        IAsyncAction RenameAsync([In] string desiredName, [In] NameCollisionOption option);

        FileAttributes Attributes { get; }

        Windows.Foundation.DateTime DateCreated { get; }

        string Name { get; }

        string Path { get; }
    }
}

