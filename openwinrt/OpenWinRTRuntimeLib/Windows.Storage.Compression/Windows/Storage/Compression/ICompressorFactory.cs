namespace Windows.Storage.Compression
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(Compressor)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5f3d96a4, 0x2cfb, 0x442c, 0xa8, 0xba, 0xd7, 0xd1, 0x1b, 3, 0x9d, 160)]
    internal interface ICompressorFactory
    {
        Compressor CreateCompressor([In] IOutputStream underlyingStream);
        Compressor CreateCompressorEx([In] IOutputStream underlyingStream, [In] CompressAlgorithm algorithm, [In] uint blockSize);
    }
}

