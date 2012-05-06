namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(QuickLink)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x603e4308, 0xf0be, 0x4adc, 0xac, 0xc9, 0x8b, 0x27, 0xab, 0x9c, 0xf5, 0x56)]
    internal interface IQuickLink
    {
        string Id { get; [param: In] set; }

        IVector<string> SupportedDataFormats { get; }

        IVector<string> SupportedFileTypes { get; }

        RandomAccessStreamReference Thumbnail { get; [param: In] set; }

        string Title { get; [param: In] set; }
    }
}

