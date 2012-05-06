namespace Windows.Storage.Pickers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Version(0x6020000)]
    public sealed class FilePickerSelectedFilesArray : IVectorView<StorageFile>, IIterable<StorageFile>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<StorageFile> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public StorageFile GetAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public uint GetMany([In] uint startIndex, [Out] StorageFile[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IndexOf([In] StorageFile value, out uint index);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

