namespace Windows.Storage.FileProperties
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DocumentProperties)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x7eab19bc, 0x1821, 0x4923, 180, 0xa9, 10, 0xea, 0x40, 0x4d, 0, 0x70)]
    internal interface IDocumentProperties : IStorageItemExtraProperties
    {
        IVector<string> Author { get; }

        string Comment { get; [param: In] set; }

        IVector<string> Keywords { get; }

        string Title { get; [param: In] set; }
    }
}

