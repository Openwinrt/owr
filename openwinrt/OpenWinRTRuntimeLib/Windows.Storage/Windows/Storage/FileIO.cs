namespace Windows.Storage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Threading(ThreadingModel.Both), Version(0x6020000), Static(typeof(IFileIOStatics), 0x6020000)]
    public static class FileIO
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AppendLinesAsync")]
        public static IAsyncAction AppendLinesAsync([In] IStorageFile file, [In] IIterable<string> lines);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AppendLinesWithEncodingAsync")]
        public static IAsyncAction AppendLinesAsync([In] IStorageFile file, [In] IIterable<string> lines, [In] UnicodeEncoding encoding);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AppendTextAsync")]
        public static IAsyncAction AppendTextAsync([In] IStorageFile file, [In] string contents);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AppendTextWithEncodingAsync")]
        public static IAsyncAction AppendTextAsync([In] IStorageFile file, [In] string contents, [In] UnicodeEncoding encoding);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<IBuffer> ReadBufferAsync([In] IStorageFile file);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ReadLinesAsync")]
        public static IAsyncOperation<IVector<string>> ReadLinesAsync([In] IStorageFile file);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ReadLinesWithEncodingAsync")]
        public static IAsyncOperation<IVector<string>> ReadLinesAsync([In] IStorageFile file, [In] UnicodeEncoding encoding);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ReadTextAsync")]
        public static IAsyncOperation<string> ReadTextAsync([In] IStorageFile file);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ReadTextWithEncodingAsync")]
        public static IAsyncOperation<string> ReadTextAsync([In] IStorageFile file, [In] UnicodeEncoding encoding);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncAction WriteBufferAsync([In] IStorageFile file, [In] IBuffer buffer);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncAction WriteBytesAsync([In] IStorageFile file, [In] byte[] buffer);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("WriteLinesAsync")]
        public static IAsyncAction WriteLinesAsync([In] IStorageFile file, [In] IIterable<string> lines);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("WriteLinesWithEncodingAsync")]
        public static IAsyncAction WriteLinesAsync([In] IStorageFile file, [In] IIterable<string> lines, [In] UnicodeEncoding encoding);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("WriteTextAsync")]
        public static IAsyncAction WriteTextAsync([In] IStorageFile file, [In] string contents);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("WriteTextWithEncodingAsync")]
        public static IAsyncAction WriteTextAsync([In] IStorageFile file, [In] string contents, [In] UnicodeEncoding encoding);
    }
}

