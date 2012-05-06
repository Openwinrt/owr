namespace Windows.Storage.Compression
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), Activatable(typeof(IDecompressorFactory), 0x6020000)]
    public sealed class Decompressor : IDecompressor, IInputStream, IClosable
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Decompressor([In] IInputStream underlyingStream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Close();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IInputStream DetachStream();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<IBuffer, uint> ReadAsync([In] IBuffer buffer, [In] uint count, [In] InputStreamOptions options);
    }
}

