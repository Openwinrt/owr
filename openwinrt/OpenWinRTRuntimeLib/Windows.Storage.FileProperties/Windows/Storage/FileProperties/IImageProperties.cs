namespace Windows.Storage.FileProperties
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ImageProperties)), Windows.Foundation.Metadata.Guid(0x523c9424, 0xfcff, 0x4275, 0xaf, 0xee, 0xec, 0xdb, 0x9a, 180, 0x79, 0x73), Version(0x6020000)]
    internal interface IImageProperties : IStorageItemExtraProperties
    {
        Windows.Foundation.DateTime DateTaken { get; [param: In] set; }

        uint Height { get; }

        IVector<string> Keywords { get; }

        uint Rating { get; [param: In] set; }

        string Title { get; [param: In] set; }

        uint Width { get; }
    }
}

