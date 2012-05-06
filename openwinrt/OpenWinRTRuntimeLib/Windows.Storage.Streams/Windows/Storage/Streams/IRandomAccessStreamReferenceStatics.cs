namespace Windows.Storage.Streams
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Windows.Foundation.Metadata.Guid(0x857309dc, 0x3fbf, 0x4e7d, 0x98, 0x6f, 0xef, 0x3b, 0x1a, 7, 0xa9, 100), ExclusiveTo(typeof(RandomAccessStreamReference)), Version(0x6020000)]
    internal interface IRandomAccessStreamReferenceStatics
    {
        RandomAccessStreamReference CreateFromFile([In] IStorageFile file);
        RandomAccessStreamReference CreateFromStream([In] IRandomAccessStream stream);
        RandomAccessStreamReference CreateFromUri([In] Uri uri);
    }
}

