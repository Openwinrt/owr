namespace Windows.Storage.Streams
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class FileOutputStream : IOutputStream, IClosable
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Close();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<bool> FlushAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperationWithProgress<uint, uint> WriteAsync([In] IBuffer buffer);
    }
}

