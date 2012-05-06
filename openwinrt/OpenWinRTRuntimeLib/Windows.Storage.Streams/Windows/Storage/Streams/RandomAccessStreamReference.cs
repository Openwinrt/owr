namespace Windows.Storage.Streams
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IRandomAccessStreamReferenceStatics), 0x6020000)]
    public sealed class RandomAccessStreamReference : IRandomAccessStreamReference
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static RandomAccessStreamReference CreateFromFile([In] IStorageFile file);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static RandomAccessStreamReference CreateFromStream([In] IRandomAccessStream stream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static RandomAccessStreamReference CreateFromUri([In] Uri uri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IRandomAccessStreamWithContentType> OpenReadAsync();
    }
}

