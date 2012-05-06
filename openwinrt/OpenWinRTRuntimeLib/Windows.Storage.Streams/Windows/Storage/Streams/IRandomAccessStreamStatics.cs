namespace Windows.Storage.Streams
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(RandomAccessStream)), Windows.Foundation.Metadata.Guid(0x524cedcf, 0x6e29, 0x4ce5, 0x95, 0x73, 0x6b, 0x75, 0x3d, 0xb6, 0x6c, 0x3a), Version(0x6020000)]
    internal interface IRandomAccessStreamStatics
    {
        IAsyncOperationWithProgress<ulong, ulong> CopyAndCloseAsync([In] IInputStream source, [In] IOutputStream destination);
        [Overload("CopyAsync")]
        IAsyncOperationWithProgress<ulong, ulong> CopyAsync([In] IInputStream source, [In] IOutputStream destination);
        [Overload("CopySizeAsync")]
        IAsyncOperationWithProgress<ulong, ulong> CopyAsync([In] IInputStream source, [In] IOutputStream destination, [In] ulong bytesToCopy);
    }
}

