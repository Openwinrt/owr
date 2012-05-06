namespace Windows.Storage.Compression
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Activatable(typeof(ICompressorFactory), 0x6020000), Version(0x6020000)]
    public sealed class Compressor : ICompressor, IOutputStream, IClosable
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Compressor([In] IOutputStream underlyingStream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Compressor([In] IOutputStream underlyingStream, [In] CompressAlgorithm algorithm, [In] uint blockSize);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Close();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IOutputStream DetachStream();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public StreamFlushOperation FinishAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<bool> FlushAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<uint, uint> WriteAsync([In] IBuffer buffer);
    }
}

