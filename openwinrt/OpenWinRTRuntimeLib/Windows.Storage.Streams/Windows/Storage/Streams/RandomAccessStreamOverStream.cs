namespace Windows.Storage.Streams
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class RandomAccessStreamOverStream : IRandomAccessStream, IClosable, IInputStream, IOutputStream
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IRandomAccessStream CloneStream();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Close();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<bool> FlushAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IInputStream GetInputStreamAt([In] ulong position);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IOutputStream GetOutputStreamAt([In] ulong position);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<IBuffer, uint> ReadAsync([In] IBuffer buffer, [In] uint count, [In] InputStreamOptions options);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Seek([In] ulong position);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<uint, uint> WriteAsync([In] IBuffer buffer);

        public bool CanRead { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool CanWrite { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.Storage.Streams.IRandomAccessStream.CanRead { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Storage.Streams.IRandomAccessStream.CanWrite { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong Windows.Storage.Streams.IRandomAccessStream.Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong Windows.Storage.Streams.IRandomAccessStream.Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

