namespace Windows.Storage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Threading(ThreadingModel.Both), Static(typeof(IPathIOStatics), 0x6020000), Version(0x6020000)]
    public static class PathIO
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AppendLinesAsync")]
        public static IAsyncAction AppendLinesAsync([In] string absolutePath, [In] IIterable<string> lines);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AppendLinesWithEncodingAsync")]
        public static IAsyncAction AppendLinesAsync([In] string absolutePath, [In] IIterable<string> lines, [In] UnicodeEncoding encoding);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AppendTextAsync")]
        public static IAsyncAction AppendTextAsync([In] string absolutePath, [In] string contents);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("AppendTextWithEncodingAsync")]
        public static IAsyncAction AppendTextAsync([In] string absolutePath, [In] string contents, [In] UnicodeEncoding encoding);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<IBuffer> ReadBufferAsync([In] string absolutePath);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ReadLinesAsync")]
        public static IAsyncOperation<IVector<string>> ReadLinesAsync([In] string absolutePath);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ReadLinesWithEncodingAsync")]
        public static IAsyncOperation<IVector<string>> ReadLinesAsync([In] string absolutePath, [In] UnicodeEncoding encoding);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ReadTextAsync")]
        public static IAsyncOperation<string> ReadTextAsync([In] string absolutePath);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ReadTextWithEncodingAsync")]
        public static IAsyncOperation<string> ReadTextAsync([In] string absolutePath, [In] UnicodeEncoding encoding);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncAction WriteBufferAsync([In] string absolutePath, [In] IBuffer buffer);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncAction WriteBytesAsync([In] string absolutePath, [In] byte[] buffer);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("WriteLinesAsync")]
        public static IAsyncAction WriteLinesAsync([In] string absolutePath, [In] IIterable<string> lines);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("WriteLinesWithEncodingAsync")]
        public static IAsyncAction WriteLinesAsync([In] string absolutePath, [In] IIterable<string> lines, [In] UnicodeEncoding encoding);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("WriteTextAsync")]
        public static IAsyncAction WriteTextAsync([In] string absolutePath, [In] string contents);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("WriteTextWithEncodingAsync")]
        public static IAsyncAction WriteTextAsync([In] string absolutePath, [In] string contents, [In] UnicodeEncoding encoding);
    }
}

