namespace Windows.Storage.Streams
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Static(typeof(IRandomAccessStreamStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public static class RandomAccessStream
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperationWithProgress<ulong, ulong> CopyAndCloseAsync([In] IInputStream source, [In] IOutputStream destination);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CopyAsync")]
        public static IAsyncOperationWithProgress<ulong, ulong> CopyAsync([In] IInputStream source, [In] IOutputStream destination);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CopySizeAsync")]
        public static IAsyncOperationWithProgress<ulong, ulong> CopyAsync([In] IInputStream source, [In] IOutputStream destination, [In] ulong bytesToCopy);
    }
}

