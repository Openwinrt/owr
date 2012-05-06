namespace Windows.Storage.Compression
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5337e252, 0x1da2, 0x42e1, 0x88, 0x34, 3, 0x79, 210, 0x8d, 0x74, 0x2f), ExclusiveTo(typeof(Decompressor))]
    internal interface IDecompressorFactory
    {
        Decompressor CreateDecompressor([In] IInputStream underlyingStream);
    }
}

